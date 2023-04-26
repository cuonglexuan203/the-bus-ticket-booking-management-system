create proc [dbo].[pro_CancelTicket] @id_ticket char(20)
as
begin 
	update TICKET set status = 0 where id_ticket = @id_ticket
	delete from BOOKING from BOOKING.id_ticket = @id_ticket;
end
go

-- different with trigger delete trip: this procedure reserve infor of trip in tables ( trip_driver, trip_agent, ... ) in case
-- need to active again
create proc pro_SetCancelTrip @id_trip char(20)
as 
begin
	update TRIP set status = 'cancel' where id_trip = @id_trip
end
go

--
create proc pro_SetFinishTrip @id_trip char(20)
as 
begin
	update TRIP set status = 'finish' where id_trip = @id_trip
end
go
--
create proc pro_SetGoingTrip @id_trip char(20)
as 
begin
	update TRIP set status = 'going' where id_trip = @id_trip
end
go

--
create proc pro_AddDefaultBooking @id_ticket char(20), @id_passenger char(20)
as
begin
	update TICKET set TICKET.status = 1 where TICKET.id_ticket = @id_ticket;
	insert into BOOKING(id_ticket, id_passenger, id_employee, booking_time) values (@id_ticket, @id_passenger, dbo.func_AutoDefaultIdEmployee(), GETDATE());
end
go
--
create proc [dbo].[pro_AddBooking] @id_ticket char(20), @id_passenger char(20), @id_employee char(20)
as
begin
	update TICKET set TICKET.status = 1 where TICKET.id_ticket = @id_ticket;
	insert into BOOKING(id_ticket, id_passenger, id_employee, booking_time) values (@id_ticket, @id_passenger, @id_employee, GETDATE());
end
go
--
create proc [dbo].[pro_AddPassenger] @id_passenger char(20), @name nvarchar(50), @phone char(20)
as
begin 
insert into PASSENGER(id_passenger, name, phone_number) values (@id_passenger, @name, @phone);
end;
go
--
create proc dbo.pro_AddPassengerAccount @id_passenger char(20), @username varchar(50), @password varchar(50)
as
begin
insert into PASSENGERACCOUNT values (@id_passenger, @username, @password);
end;
go
--
create proc [dbo].[pro_AssignPassengerPrivilege] (@id_passenger char(20))
as
SET XACT_ABORT ON
begin 
	declare @username varchar(50), @sqlString nvarchar(MAX)
	select @username = PASSENGERACCOUNT.username from PASSENGERACCOUNT where PASSENGERACCOUNT.id_passenger = @id_passenger;
	set @sqlString = 'exec sp_addrolemember ''rol_Passenger'', ''' + @username + '''';
	exec sp_executesql @sqlString;
end
go
--
create proc dbo.pro_AddEmployeeAccount (@username varchar(50), @password varchar(50))
as
begin
	insert into SYSTEMACCOUNT(username, pass) values (@username, @password);
end
go
--
create proc dbo.pro_AssignSystemPrivilege (@id_employee char(20), @id_position char(20))
as
begin 
	SET XACT_ABORT ON
	begin tran
		begin try
			declare @username varchar(50), @position_name varchar(50), @sqlString varchar(1000)
		--
			select @username = b.username 
			from EMPLOYEE as a inner join SYSTEMACCOUNT as b on a.id_account = b.id_account 
			where a.id_employee = @id_employee;
			--
			select @position_name = a.type from POSITION as a where a.id_position = @id_position;
		--
			if(@position_name = 'administrator')
				set @sqlString = 'exec sp_addrolemember ''rol_Admin'', ''' + @username + '''';
			else
				set @sqlString = 'exec sp_addrolemember ''rol_Staff'', ''' + @username + '''';
			exec @sqlString;
			insert into EMPLOYEE_POSITION values(@id_employee, @id_position);
			commit tran;
		end try
		begin catch
		rollback;
		end catch
end
go
--
