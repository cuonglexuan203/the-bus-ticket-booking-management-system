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
create function [dbo].[func_ValidatePassengerAccount] (@username varchar(50), @password varchar(50))
returns varchar(20)
as
begin
	declare @id_passenger as varchar(20) = null, @errMsg as varchar(MAX);
	select @id_passenger = tb.id_passenger from PASSENGERACCOUNT as tb where tb.username = @username and tb.password = @password;
	if @id_passenger is null
	begin
		set @errMsg = 'Invalid username or password!';
		throw 5000, @errMsg, 1;
	end
	return @id_passenger;
end