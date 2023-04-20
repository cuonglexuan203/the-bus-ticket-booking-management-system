create proc pro_CancelTicket @id_ticket char(20)
as
begin 
	update TICKET set status = 0 where id_ticket = @id_ticket
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
