use BusManagement
-- the following views is the user views
go
-- all trip in the database
create view [dbo].[V_TRIPINFOR]
as
select a.id_trip as [Trip ID], b.registration_number as [Registration number of bus], c.region as [Start point], d.region as [End point]
, a.departure_time as [Departure time], a.duration as [Duration], b.capacity - a.booked_seat as [Remain seat], a.status as [Status]
from TRIP as a
inner join BUS as b on a.id_bus = b.id_bus
inner join (
    select BUSROUTE.id_route, PLACE.region
    from BUSROUTE inner join BUSSTATION on BUSROUTE.id_start_station = BUSSTATION.id_bus_station
    inner join PLACE on BUSSTATION.id_place = PLACE.id_place
) as c on a.id_bus_route = c.id_route
inner join (
   select BUSROUTE.id_route, PLACE.region
    from BUSROUTE inner join BUSSTATION on BUSROUTE.id_end_station = BUSSTATION.id_bus_station
    inner join PLACE on BUSSTATION.id_place = PLACE.id_place
) as d on a.id_bus_route = d.id_route

go

-- only available trip ( which has available slots and departure time greater than current)
create view V_AVAILABLETRIP
as
select a.id_trip as [Trip ID], b.registration_number as [Registration number of bus], c.region as [Start point], d.region as [End point]
, a.departure_time as [Departure time], a.duration as [Duration], b.capacity - a.booked_seat as [Remain seat], a.status as [Status]
from TRIP as a
inner join BUS as b on a.id_bus = b.id_bus
inner join (
    select BUSROUTE.id_route, PLACE.region
    from BUSROUTE inner join BUSSTATION on BUSROUTE.id_start_station = BUSSTATION.id_bus_station
    inner join PLACE on BUSSTATION.id_place = PLACE.id_place
) as c on a.id_bus_route = c.id_route
inner join (
   select BUSROUTE.id_route, PLACE.region
    from BUSROUTE inner join BUSSTATION on BUSROUTE.id_end_station = BUSSTATION.id_bus_station
    inner join PLACE on BUSSTATION.id_place = PLACE.id_place
) as d on a.id_bus_route = d.id_route
where b.capacity - a.booked_seat > 0 and convert(datetime, a.departure_time) > getdate()

go

-- view route for passenger selections
create view [dbo].[V_ROUTEINFOR] as
with BUSSTATION_PLACE_CTE as
(
    select BUSSTATION.id_bus_station, PLACE.region
    from BUSSTATION inner join PLACE on BUSSTATION.id_place = PLACE.id_place
)
select a.id_route, b.region as [Start point], c.region as [End point], a.distance as [Distance]
from BUSROUTE as a inner join BUSSTATION_PLACE_CTE as b on a.id_start_station = b.id_bus_station
inner join BUSSTATION_PLACE_CTE as c on a.id_end_station = c.id_bus_station
go

create view [dbo].[V_BOOKINGINFOR] as
select a.id_booking as [Booking ID], a.id_passenger as [Passenger ID], a.id_ticket as [Ticket ID], b.name as [Passenger name], b.gender as [Passenger gender], b.phone_number as [Passenger phone number],
c.name as [Employee name], c.gender as [Employee gender], c.phone_number as [Employee phone number], a.booking_time as [Booking time]
from BOOKING as a
inner join PASSENGER as b on a.id_passenger = b.id_passenger
inner join EMPLOYEE as c on a.id_employee = c.id_employee 

go
--
create view V_BUSSTATIONINFOR as
select a.id_place, a.phone as [Phone number], a.address as [Address], b.region as [Region]
from BUSSTATION as a
inner join PLACE as b on a.id_place = b.id_place

go

create view [dbo].[V_AGENTINFOR] as
select a.id_agent as [Agent ID], a.phone as [Phone], a.address as [Address], b.region as [Region] , c.counter as [Money]
from AGENT as a
inner join PLACE as b on a.id_place = b.id_place
inner join CASHRESERVE as c on a.id_cash_reserve = c.id_cash_reserve
go
--
create view [dbo].[V_EMPLOYEEINFOR] as
select a.id_employee as [Employees ID], a.name as [Name], a.phone_number as [Phone Number],a.address as [Address], a.email as [Email]
, a.identity_number as [Identity number], a.salary as [Salary], a.birthdate as [Birthday] , a.gender as [Gender], a.[state] as [State], c.type
from EMPLOYEE as a left join EMPLOYEE_POSITION as b on a.id_employee = b.id_employee
 left join POSITION as c on b.id_position = c.id_position

go
--
create view [dbo].[V_DRIVERINFOR] as
select a.id_employee as [Employees ID], a.name as [Name], a.phone_number as [Phone Number], a.gender as [Gender]
, b.lisence_level as [Lisence Level], 
case
	when b.type = 0 then 'Interprovince'
	else 'Transit'
end as [Type],
case
	when b.state = 1 then 'Is driving'
	else 'Idle'
end as [State]
from EMPLOYEE as a inner join DRIVER as b on a.id_employee = b.id_driver
go
--
create view V_USERINFOR as
select a.id_passenger, a.name, a.phone_number, b.username, b.password from PASSENGER as a inner join PASSENGERACCOUNT as b on a.id_passenger = b.id_passenger
go
--
create view [dbo].[V_BOOKEDTICKET] as
select a.[Passenger ID], b.id_ticket as [Ticket ID], b.fare as [Fare], 
	case 
		when b.type = 0 then 'Seat'
		else 'Sleeper'
	end as [Type]
, b.seat_number as [Seat number],
c.[Start point] as [Start point], d.[End point] as [End point], c.[Departure time] , d.Distance as [Distance], c.Duration as [Duration],
c.[Registration number of bus] as [Registration number of bus], a.[Booking time] as [Booking time]
from V_BOOKINGINFOR as a inner join TICKET as b on a.[Ticket ID] = b.id_ticket
inner join V_TRIPINFOR as c on b.id_trip = c.[Trip ID]
inner join V_ROUTEINFOR as d on c.[Start point] = d.[Start point] and c.[End point] = d.[End point]
go
--
