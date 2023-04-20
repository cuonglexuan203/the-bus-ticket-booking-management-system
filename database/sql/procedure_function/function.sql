-- default employee id for booking
create function dbo.func_AutoDefaultIdEmployee()
returns char(20)
as
begin 
	return 'emp_0000000000';
end
go

--
create function [dbo].[func_GetAvailabelSeat](@idTrip char(20), @type bit)
returns table
as
return (select TICKET.seat_number from TICKET where TICKET.id_trip = @idTrip and TICKET.type = @type and TICKET.status = 0)
go
--
create function [dbo].[func_AddPassenger](@name nvarchar(50), @phone char(20))
returns char(20)
as 
begin
declare @id_passenger char(20)
set @id_passenger = dbo.func_auto_id_passenger();
exec dbo.pro_AddPassenger @id_passenger, @name, @phone;
return @id_passenger
end