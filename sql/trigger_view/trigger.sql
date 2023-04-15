create trigger tr_DeleteEmployee on Employee
instead of delete
as

declare @employee_id char(20), @account_id char(20)
select @employee_id = d.id_employee, @account_id = d.id_account  from deleted d
set xact_abort on

begin 
begin try


update EMPLOYEE 
set state = 0
where id_employee = @employee_id;

delete from EMPLOYEE_POSITION where id_employee = @employee_id;

delete from SYSTEMACCOUNT where id_account = @account_id

commit tran
end try

begin catch

rollback tran

end catch
end;

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
			select @new_booked_seat = TRIP.booked_seat, @new_status = TRIP.status from TRIP where id_trip = @id_trip
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