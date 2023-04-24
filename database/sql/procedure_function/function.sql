-- default employee id for booking
create function dbo.func_AutoDefaultIdEmployee()
returns char(20)
as
begin 
	return 'emp_0000000001';
end
go

--
create function [dbo].[func_GetAvailabelSeat](@idTrip char(20), @type bit)
returns table
as
return (select TICKET.seat_number from TICKET where TICKET.id_trip = @idTrip and TICKET.type = @type and TICKET.status = 0)
go
--
