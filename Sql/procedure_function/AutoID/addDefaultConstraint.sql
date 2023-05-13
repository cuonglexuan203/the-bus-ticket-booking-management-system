alter table SYSTEMACCOUNT
add constraint AUTO_IDACCOUNT default dbo.func_auto_id_account() for id_account
go
--
alter table AGENT
add constraint AUTO_IDAGENT default dbo.func_auto_id_agent() for id_agent
go
--
alter table BOOKING
add constraint AUTO_IDBOOKING default dbo.func_auto_id_booking() for id_booking
go
--
alter table BUS
add constraint AUTO_IDBUS default dbo.func_auto_id_bus() for id_bus
go
--
alter table BUSROUTE
add constraint AUTO_IDROUTE default dbo.func_auto_id_busroute() for id_route
go
--
alter table BUSSTATION
add constraint AUTO_IDBUSSTATION default dbo.func_auto_id_busstation() for id_bus_station
go
--
alter table CASHRESERVE
add constraint AUTO_IDCASHRESERVE default dbo.func_auto_id_cashreserve() for id_cash_reserve
go
--
alter table EMPLOYEE
add constraint AUTO_IDEMPLOYEE default dbo.func_auto_id_employee() for id_employee
go
--
alter table EVENT
add constraint AUTO_IDEVENT default dbo.func_auto_id_event() for id_event
go
--
alter table PACKAGE
add constraint AUTO_IDPACKAGE default dbo.func_auto_id_package() for id_package
go
--
alter table PASSENGER
add constraint AUTO_IDPASSENGER default dbo.func_auto_id_passenger() for id_passenger
go
--
alter table PACKAGEPRICEPOLICY
add constraint AUTO_IDPOLICY default dbo.func_auto_id_policy() for id_policy
go
--
alter table POSITION
add constraint AUTO_IDPOSITION default dbo.func_auto_id_position() for id_position
go
--
alter table PRIVILEGE
add constraint AUTO_IDPRIVILEGE default dbo.func_auto_id_privilege() for id_privilege
go
--
alter table REFUND
add constraint AUTO_IDREFUND default dbo.func_auto_id_refund() for id_refund
go
--
alter table TICKET
add constraint AUTO_IDTICKET default dbo.func_auto_id_ticket() for id_ticket
go
--
alter table TRIP
add constraint AUTO_IDTRIP default dbo.func_auto_id_trip() for id_trip
go
--

