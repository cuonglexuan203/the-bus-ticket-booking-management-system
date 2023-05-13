use BusManagement;
exec sp_addrole rol_Passenger;
go
--
-- grant tables
grant select on AGENT to rol_Passenger;
grant select, insert, delete, references on BOOKING to rol_Passenger;
grant select on BUS to rol_Passenger;
grant select on BUSROUTE to rol_Passenger;
grant select on BUSSTATION to rol_Passenger;
grant select on BUSROUTE_BUSSTATION TO rol_Passenger;
grant select, insert, update, references on PASSENGER to rol_Passenger;
grant select, insert, update, references on PASSENGERACCOUNT to rol_Passenger;
grant select on PLACE to rol_Passenger;
grant select on TICKET to rol_Passenger;
grant select on TRIP to rol_Passenger;
--
--grant views
grant select on V_AGENTINFOR to rol_Passenger;
grant select on V_AVAILABLETRIP to rol_Passenger;
grant select on V_BOOKEDTICKET to rol_Passenger;
grant select on V_BOOKINGINFOR to rol_Passenger;
grant select on V_BUSSTATIONINFOR to rol_Passenger;
grant select on V_DRIVERINFOR to rol_Passenger;
grant select on V_ROUTEINFOR to rol_Passenger;
grant select on V_TRIPINFOR to rol_Passenger;
grant select on V_USERINFOR to rol_Passenger;

--
-- grant procedures
grant execute on dbo.pro_AddBooking to rol_Passenger;
grant execute on dbo.pro_AddDefaultBooking to rol_Passenger;
grant execute on dbo.pro_AddPassenger to rol_Passenger;
grant execute on dbo.pro_AddPassengerAccount to rol_Passenger
grant execute on dbo.pro_CancelTicket to rol_Passenger;
grant execute on dbo.pro_ChangePassengerPassword to rol_Passenger;
grant execute on dbo.pro_ValidateUser to rol_Passenger;
--
-- grant functions
grant execute on dbo.func_auto_id_booking to rol_Passenger;
grant execute on dbo.func_auto_id_passenger to rol_Passenger;
grant select on dbo.func_GetAvailabelSeat to rol_Passenger;

--
-- deny 
deny delete on PASSENGER to rol_Passenger;
deny update, insert, delete, references on AGENT to rol_Passenger;
deny update, insert, delete, references on BUS to rol_Passenger;
deny update, insert, delete, references on BUSROUTE to rol_Passenger;
deny update, insert, delete, references on BUSSTATION to rol_Passenger;
deny select, update, insert, delete, references on CASHRESERVE to rol_Passenger;
deny select, update, insert, delete, references on EMPLOYEE to rol_Passenger;
deny delete on PACKAGE to rol_Passenger;
deny update, insert, delete, references on PLACE to rol_Passenger;
deny select, update, insert, delete, references on POSITION to rol_Passenger;
deny select, update, insert, delete, references on SYSTEMACCOUNT to rol_Passenger;
deny update, insert, delete, references on TRIP to rol_Passenger;



--

--
exec sp_addrole rol_Staff;
go
--
-- grant tables
grant select on AGENT to rol_Staff;
grant select, insert, delete, references on BOOKING to rol_Staff;
grant select on BUS to rol_Staff;
grant select on BUSROUTE to rol_Staff;
grant select on BUSSTATION to rol_Staff;
grant select on BUSROUTE_BUSSTATION TO rol_Staff;
grant select, insert, update, delete, references on PASSENGER to rol_Staff;
grant select, insert, update, delete, references on PASSENGERACCOUNT to rol_Staff;
grant select on PLACE to rol_Staff;
grant select, update on TICKET to rol_Staff;
grant select on TRIP to rol_Staff;
grant select, update on EMPLOYEE to rol_Staff;
grant select, update on SYSTEMACCOUNT to rol_Staff;

--
--grant views
grant select on V_AGENTINFOR to rol_Staff;
grant select on V_AVAILABLETRIP to rol_Staff;
grant select on V_BOOKEDTICKET to rol_Staff;
grant select on V_BOOKINGINFOR to rol_Staff;
grant select on V_BUSSTATIONINFOR to rol_Staff;
grant select on V_ROUTEINFOR to rol_Staff;
grant select on V_TRIPINFOR to rol_Staff;
grant select on V_USERINFOR to rol_Staff;
grant select on V_EMPLOYEEINFOR to rol_Staff;
grant select on V_DRIVERINFOR to rol_Staff;

--
-- grant procedures
grant execute on dbo.pro_AddBooking to rol_Staff;
grant execute on dbo.pro_AddDefaultBooking to rol_Staff;
grant execute on dbo.pro_AddPassenger to rol_Staff;
grant execute on dbo.pro_AddPassengerAccount to rol_Staff
grant execute on dbo.pro_CancelTicket to rol_Staff;
grant execute on dbo.pro_ChangePassengerPassword to rol_Staff;
grant execute on dbo.pro_ChangeSystemPassword to rol_Staff;
grant execute on dbo.pro_ValidateUser to rol_Staff;

--
-- grant functions
grant execute on dbo.func_auto_id_booking to rol_Staff;
grant execute on dbo.func_auto_id_passenger to rol_Staff;
grant select on dbo.func_GetAvailabelSeat to rol_Staff;
grant execute on dbo.func_auto_id_employee to rol_Staff;

--
-- deny 
deny delete on PASSENGER to rol_Staff;
deny update, insert, delete, references on AGENT to rol_Staff;
deny update, insert, delete, references on BUS to rol_Staff;
deny update, insert, delete, references on BUSROUTE to rol_Staff;
deny update, insert, delete, references on BUSSTATION to rol_Staff;
deny select, update on CASHRESERVE to rol_Staff;
deny insert, delete, references on EMPLOYEE to rol_Staff;
deny update, insert, delete, references on PLACE to rol_Staff;
deny select, update, insert, delete, references on POSITION to rol_Staff;
deny insert, delete, references on SYSTEMACCOUNT to rol_Staff;
deny update, insert, delete, references on TRIP to rol_Staff;

--
--
--
exec sp_addrole rol_Admin;
grant control on DATABASE::BusManagement to rol_Admin;
grant alter any user to rol_Admin;

-- use master
-- grant alter any login to admin01