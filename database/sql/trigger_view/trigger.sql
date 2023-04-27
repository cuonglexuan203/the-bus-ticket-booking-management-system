-- alow delete ticket ( in past, future), only reserve trip

create  trigger [dbo].[tr_DeleteEmployee] on [dbo].[EMPLOYEE]
instead of delete
as

declare @employee_id char(20), @account_id char(20)
select @employee_id = d.id_employee, @account_id = d.id_account  from deleted d
set xact_abort on

begin 
	begin tran
	begin try

		update EMPLOYEE 
		set state = 0
		where id_employee = @employee_id;
		--
		delete from EMPLOYEE_POSITION where id_employee = @employee_id;
		--
		declare @username varchar(30)
		select @username = sysa.username from SYSTEMACCOUNT sysa where sysa.id_account = @account_id
		--
		declare @query varchar(MAX)
		set @query = 'drop user [' + @username + ']'
		exec (@query)
		--
		set @query = 'drop login [' + @username + ']'
		exec (@query)
		--
		delete from SYSTEMACCOUNT where id_account = @account_id
		commit tran
	end try

	begin catch

		rollback

	end catch
end;

go
--
create trigger [dbo].[tr_CreateSystemAccount] on [dbo].[SYSTEMACCOUNT]
after insert
as
declare @username varchar(30), @password varchar(10)
select @username = ins.username, @password = ins.pass from inserted ins
begin
	begin tran
		begin try
			declare @query varchar(2000)
			set @query = 'create login [' + @username + '] with password = ''' + @password + ''',
			default_database = [BusManagement], check_expiration = off, check_policy = off'
			exec (@query);

			set @query = 'create user [' + @username + '] for login ' + @username
			exec (@query);
			commit tran;
		end try
		begin catch
			rollback
		end catch
end
go
--

create trigger tr_DeleteTrip on TRIP
instead of delete
as
declare @id_trip char(20), @status char(15)
select @id_trip = ol.id_trip, @status = ol.status from deleted as ol
set xact_abort on
begin
		begin try
			begin tran
			update TRIP set status = 'cancel' where id_trip = @id_trip;
			-- set state of driver who drives the deleted trip
			if @status = 'going'
				update DRIVER set state = 0 where id_driver in (select id_driver from TRIP_DRIVER where id_trip = @id_trip)
			--
			delete from TRIP_DRIVER where id_trip = @id_trip;
			delete from AGENT_TRIP where id_trip = @id_trip;
			commit tran
		end try
		begin catch
			rollback tran
		end catch
end

go
--
create trigger tr_UpdateTrip on TRIP
after update
as
declare @id_trip char(20),@id_bus char(20), @id_bus_route char(20), @departure_time datetime, @duration int
, @old_booked_seat tinyint, @status char(15)
select @id_trip = ol.id_trip, @old_booked_seat = ol.booked_seat, @status = ol.status from deleted as ol
set xact_abort on
begin
	begin try
		begin tran
			declare @new_booked_seat tinyint, @max_seat tinyint, @new_status char(15)
			select @new_booked_seat = i.booked_seat, @new_status = i.status from inserted i
			select @max_seat from TRIP inner join BUS on TRIP.id_bus = BUS.id_bus where TRIP.id_trip = @id_trip
			if @new_booked_seat > @max_seat
				begin
					print('booked_seat greater than max_seat of bus. Back to the old record!');
					update TRIP set id_bus = @id_bus, id_bus_route = @id_bus_route, departure_time = @departure_time
					, duration = @duration, booked_seat = @old_booked_seat, status = @status where id_trip = @id_trip;
					commit tran;
					return;
				end
			else 
				begin
					declare @new_state bit
					set @new_state = 0;
					if @new_status = 'going'
						set @new_state = 1;
					if @new_status in ('wating', 'finish', 'cancel')
						set @new_state = 0;
					update DRIVER set state = @new_state where id_driver in (select id_driver from TRIP_DRIVER where id_trip = @id_trip);
					commit tran;
				end
	end try
	begin catch
		rollback tran
	end catch
end;

go

--
create trigger tr_InsertTrip on TRIP
after insert
as
declare @id_trip char(20), @booked_seat tinyint, @status char(15)
select @id_trip = ol.id_trip, @booked_seat = ol.booked_seat, @status = ol.status from inserted as ol
set xact_abort on
begin
	begin try
		begin tran
			declare @max_seat tinyint
			select @max_seat from TRIP inner join BUS on TRIP.id_bus = BUS.id_bus where TRIP.id_trip = @id_trip
			if @booked_seat > @max_seat
				begin
					print('booked_seat greater than max_seat of bus. Undo!');
					delete from TRIP where id_trip = @id_trip;
					commit tran;
					return;
				end
			else 
				begin
					declare @new_state bit
					set @new_state = 0;
					if @status = 'going'
						set @new_state = 1;
					if @status in ('wating', 'finish', 'cancel')
						set @new_state = 0;
					update DRIVER set state = @new_state where id_driver in (select id_driver from TRIP_DRIVER where id_trip = @id_trip);
					commit tran;
				end
	end try
	begin catch
		rollback tran
	end catch
end;
go
--
create trigger tr_UpdateTicket on TICKET
after update
as
declare @id_trip char(20), @status bit
select @id_trip = i.id_trip, @status = i.status from inserted i
begin
	begin try
		begin tran
		if @status = 1
			update TRIP set booked_seat += 1 where id_trip = @id_trip
		else 
			update TRIP set booked_seat -= 1 where id_trip = @id_trip
		commit tran
	end try
	begin catch
		rollback
	end catch
end
go
--
create trigger tr_InsertTicket on TICKET
after insert
as
declare @id_ticket char(20), @id_trip char(20)
select @id_ticket = i.id_ticket, @id_trip = i.id_trip from inserted i
begin
	begin try
		begin tran
		declare @count tinyint, @max_seat tinyint
		select @count = count(id_ticket) from TICKET where id_trip = @id_trip
		select @max_seat = BUS.capacity from TRIP inner join BUS on TRIP.id_bus = BUS.id_bus where TRIP.id_trip = @id_trip
		if @count > @max_seat
			begin
				print('Number of ticket overhead the max_seat of bus');
				delete from TICKET where id_ticket = @id_ticket;
			end
		commit tran
	end try
	begin catch
		rollback
	end catch
end
go
-- delete position
create trigger tr_DeletePosition on POSITION
after delete
as
declare @id_positon char(20)
select @id_positon = ol.id_position from deleted ol;
begin
	begin try
		begin tran;
		delete from POSITION_PRIVILEGE where id_position = @id_positon;
		commit tran;
	end try

	begin catch
		rollback;
	end catch
end
go

-- delete privilege

create trigger tr_DeletePrivilege on PRIVILEGE
after delete
as
declare @id_privilege char(20)
select @id_privilege = ol.id_privilege from deleted ol;
begin
	begin try
		begin tran;
		delete from POSITION_PRIVILEGE where id_privilege = @id_privilege;
		commit tran;
	end try
	begin catch
		rollback;
	end catch
end
go

--
create trigger tr_DeleteBusRoute on BUSROUTE
after delete
as
declare @id_route char(20)
select @id_route = d.id_route from deleted d
begin 
	begin try
		begin tran
		delete from BUSROUTE_BUSSTATION where id_bus_route = @id_route
		commit tran
	end try
	begin catch
		rollback
	end catch
end
go
--

create trigger tr_DeleteBusstation on BUSSTATION
after delete
as
declare @id_busStation char(20)
select @id_busStation = d.id_bus_station from deleted d
begin 
	begin try
		begin tran
			delete from BUSROUTE_BUSSTATION where id_bus_station = @id_busStation
		commit tran
	end try

	begin catch
		rollback
	end catch
end

go

--

create trigger tr_DeleteAgent on AGENT
after delete
as
declare @id_agent char(20)
select @id_agent = d.id_agent from deleted d
begin 
	begin try
		begin tran
			delete from AGENT_TRIP where id_agent = @id_agent;
			delete from AGENT_EVENT where id_agent = @id_agent;
			delete from AGENT_POLICY where id_agent = @id_agent;
			delete from AGENT_REFUND where id_agent = @id_agent;
		commit tran
	end try

	begin catch
		rollback
	end catch
end
go 

--
create trigger tr_DeleteEvent on EVENT
after delete
as
declare @id_event char(20)
select @id_event = d.id_event from deleted d
begin 
	begin try
		begin tran
			delete from AGENT_EVENT where id_event = @id_event
		commit tran
	end try

	begin catch
		rollback
	end catch
end
go
--
create trigger tr_DeleteRefund on REFUND
after delete
as
declare @id_refund char(20)
select @id_refund = d.id_refund from deleted d
begin 
	begin try
		begin tran
			delete from AGENT_REFUND where id_refund = @id_refund
		commit tran
	end try

	begin catch
		rollback
	end catch
end
go
--
create  trigger [dbo].[tr_CreatePassengerAccount] on [dbo].[PASSENGERACCOUNT]
after insert
as
declare @username varchar(30), @password varchar(10)
select @username = ins.username, @password = ins.password from inserted ins
begin
	begin tran
		begin try
			declare @sql nvarchar(max);
			set @sql = 'create login ' + quotename(@username) + ' with password = ''' + @password + ''', DEFAULT_DATABASE=[BusManagement], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF';
			exec sp_executesql @sql;
			set @sql = 'create user ' + quotename(@username) + ' for login ' + quotename(@username);
			exec sp_executesql @sql;
			commit tran;
		end try
		begin catch
			rollback
		end catch
end
go
--