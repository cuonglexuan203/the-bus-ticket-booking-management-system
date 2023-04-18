-- default employee id for booking
create function dbo.func_AutoDefaultIdEmployee()
returns char(20)
as
begin 
	return 'emp_0000000000';
end