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
end