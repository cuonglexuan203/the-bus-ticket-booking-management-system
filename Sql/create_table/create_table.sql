use master;
drop database BusManagement;
create database BusManagement;
use BusManagement;

go

create table BUS
(
    id_bus char(20) primary key,
    registration_number char(15) unique not null,
    model varchar(50) not null,
    capacity tinyint default 32,
    status char(15) not null default 'idle',
    type bit not null default 0
    -- 0: interprovince, 1: transit
);

create table TRIP
(
    id_trip char(20) primary key,
    id_bus char(20) ,
    id_bus_route char(20),
    departure_time datetime not null,
    duration int not null,
    -- unit: hour,
    booked_seat tinyint default 0,
    status char(15) default 'waiting'
);

create table TICKET
(
    id_ticket char(20) primary key,
    id_trip char(20) ,
    status bit default 0,
    fare money not null,
    type bit default 0,
    -- 0: seat, 1: lie
    seat_number char(15) not null
);

create table BUSROUTE
(
    id_route char(20) primary key,
    id_start_station char(20),
    id_end_station char(20),
    distance float not null
    -- unit: km
);

create table BOOKING
(
    id_booking char(20) primary key,
    id_ticket char(20),
    id_passenger char(20),
    id_employee char(20),
    booking_time datetime default getdate(),
);

create table BUSSTATION
(
    id_bus_station char(20) primary key,
    id_place char(20),
    phone char(20),
    address nvarchar(100) not null,
    bus_capacity int not null,
    count_current_bus int null default 0,
);

create table PASSENGER
(
    id_passenger char(20) primary key,
    name varchar(50) not null,
    phone_number char(20) not null,
    address char(100) not null,
    identity_number char(20) null,
    gender bit,
    -- 0: male, 1: female
    email char(50) null,
);

create table AGENT
(
    id_agent char(20) primary key,
    id_cash_reserve char(20),
    id_place char(20),
    phone char(20),
    address nvarchar(100) not null
);

create table EMPLOYEE
(
    id_employee char(20) primary key,
    id_account char(20),
    id_agent char(20),
    name varchar(50) not null,
    address nvarchar(100) not null,
    phone_number char(20) not null,
    identity_number char(20) not null,
    salary money not null,
    email char(50) null,
    birthdate date not null,
    gender bit, -- 0: male, 1: female
    state bit default 1
    -- 0: not working, 1: is working
);

create table POSITION
(
    id_position char(20) primary key,
    type varchar(50) not null
);


create table PLACE
(
    id_place char(20) primary key,
    region nvarchar(50) not null default N'Hồ Chí Minh (TP)'
);

create table CASHRESERVE
(
    id_cash_reserve char(20) primary key,
    counter money default 0,
);

create table DRIVER
(
    id_driver char(20) primary key,
    -- foreign key
    lisence_level char(10) not null,
    type bit default 0,
    -- 0: interprovince, 1: transit
    state bit default 0
    -- 0: not drive, 1: is driving
);

create table EVENT
(
    id_event char(20) primary key,
    discount_type char(50) not null unique default 'normal',
    discount_percent float default 0.0
);

create table REFUND
(
    id_refund char(20) primary key,
    refund_name char(50) not null unique default 'cancel',
    refund_percent float default 0.0
);


create table SYSTEMACCOUNT
(
    id_account char(20) primary key,
    username char(20) not null unique,
    pass varchar(50) not null,
);

create table PASSENGERACCOUNT(
	id_passenger char(20),
	username varchar(50) primary key,
	password varchar(50) not null,
	);

create table TRIP_DRIVER
(
    id_trip char(20),
    id_driver char(20),
    primary key(id_trip, id_driver)
);


create table AGENT_TRIP
(
    id_agent char(20),
    id_trip char(20),
    primary key(id_agent, id_trip)
);

create table AGENT_EVENT
(
    id_agent char(20),
    id_event char(20),
    primary key(id_agent, id_event)
);

create table AGENT_REFUND
(
    id_agent char(20),
    id_refund char(20),
    primary key(id_agent, id_refund)
);


create table BUSROUTE_BUSSTATION
(
    id_bus_route char(20),
    id_bus_station char(20),
    primary key(id_bus_route, id_bus_station)
);

create table EMPLOYEE_POSITION
(
    id_employee char(20),
    id_position char(20),
    primary key(id_employee, id_position)
);

create table EMPLOYEE_TICKET
(
    id_employee char(20),
    id_ticket char(20),
    primary key(id_employee, id_ticket)
);


go
-- OTHER CONSTRANTS



alter table BUS add constraint CHK_bus_capacity check (capacity > 0 and status in ('idle', 'break', 'incident', 'ongoing'));

--
alter table TRIP add constraint FK_trip_id_bus foreign key (id_bus) references BUS(id_bus);
alter table TRIP add constraint FK_trip_id_bus_route foreign key (id_bus_route) references BUSROUTE(id_route);
alter table TRIP add constraint CK_trip check (duration > 0 and booked_seat >= 0 and status in ('waiting', 'going', 'finish', 'cancel'));
--
alter table TICKET add constraint FK_ticket_id_trip foreign key (id_trip) references TRIP(id_trip);
alter table TICKET add constraint CHK_ticket check(fare > 0 );
--
alter table BUSROUTE add constraint FK_busroute_id_start_bus_station foreign key (id_start_station) references BUSSTATION(id_bus_station);
alter table BUSROUTE add constraint FK_busroute_id_end_bus_station foreign key (id_end_station) references BUSSTATION(id_bus_station);
alter table BUSROUTE add constraint UC_busroute_id_start_bus_station_id_end_bus_station unique(id_start_station, id_end_station);
alter table BUSROUTE add constraint CHK_busroute check (distance > 0);
--
alter table BOOKING add constraint FK_booking_id_ticket foreign key (id_ticket) references TICKET(id_ticket);
alter table BOOKING add constraint FK_booking_id_passenger foreign key (id_passenger) references PASSENGER(id_passenger);
alter table BOOKING add constraint FK_booking_id_employee foreign key (id_employee) references EMPLOYEE(id_employee);
--
alter table BUSSTATION add constraint FK_busstation_id_place foreign key (id_place) references PLACE(id_place);
alter table BUSSTATION add constraint CHK_busstation check (bus_capacity > 0 and count_current_bus >= 0);
--
alter table PASSENGER add constraint CHK_passenger check (email like '_%@gmail.com');
--
alter table AGENT add constraint FK_agent_id_cash_reserve foreign key (id_cash_reserve) references CASHRESERVE(id_cash_reserve);
alter table AGENT add constraint FK_agent_id_place foreign key (id_place) references PLACE(id_place);
--
alter table EMPLOYEE add constraint FK_employee_id_account foreign key (id_account) references SYSTEMACCOUNT(id_account) on delete set null;
alter table EMPLOYEE add constraint FK_employee_id_agent foreign key (id_agent) references AGENT(id_agent);
alter table EMPLOYEE add constraint CHK_employee check (email like '_%@gmail.com');
--
alter table POSITION add constraint CHK_position check (type in ('administrator', 'planner', 'supervisor', 'driver', 'ticket seller', 'service guide', 'security guard', 'porter'));
--

--
--alter table PLACE add constraint CHK_place check(region in ('TP.Ho Chi Minh', 'Ha Noi', 'Phu Yen', 'Khanh Hoa', 'Ben Tre', 'Lam Dong'));
-- so on
--
alter table EVENT add constraint CHK_event check (discount_percent >= 0);
--
alter table REFUND add constraint CHK_refund check (refund_percent >= 0);
--

--
alter table PASSENGERACCOUNT
add constraint PK_passengerAccount_id_passenger foreign key (id_passenger) references PASSENGER(id_passenger);
--
alter table TRIP_DRIVER add constraint FK_trip_driver_id_trip foreign key (id_trip) references TRIP(id_trip);
alter table TRIP_DRIVER add constraint FK_trip_driver_id_driver foreign key (id_driver) references DRIVER(id_driver);
--
alter table AGENT_TRIP add constraint FK_agent_trip_id_agent foreign key (id_agent) references AGENT(id_agent);
alter table AGENT_TRIP add constraint FK_agent_trip_id_trip foreign key (id_trip) references TRIP(id_trip);
--
alter table AGENT_EVENT add constraint FK_agent_event_id_agent foreign key (id_agent) references AGENT(id_agent);
alter table AGENT_EVENT add constraint FK_agent_event_id_event foreign key (id_event) references EVENT(id_event);
--
alter table AGENT_REFUND add constraint FK_agent_refund_id_agent foreign key (id_agent) references AGENT(id_agent);
alter table AGENT_REFUND add constraint FK_agent_refund_id_refund foreign key (id_refund) references REFUND(id_refund);
--
alter table BUSROUTE_BUSSTATION add constraint FK_busroute_busstation_id_bus_route foreign key (id_bus_route) references BUSROUTE(id_route);
alter table BUSROUTE_BUSSTATION add constraint FK_busroute_busstation_id_bus_station foreign key (id_bus_station) references BUSSTATION(id_bus_station);
--
alter table EMPLOYEE_POSITION add constraint FK_employee_position_id_employee foreign key (id_employee) references EMPLOYEE(id_employee);
alter table EMPLOYEE_POSITION add constraint FK_employee_position_id_position foreign key (id_position) references POSITION(id_position);
--
alter table EMPLOYEE_TICKET add constraint FK_employee_ticket_id_employee foreign key (id_employee) references EMPLOYEE(id_employee);
alter table EMPLOYEE_TICKET add constraint FK_employee_ticket_id_ticket foreign key (id_ticket) references TICKET(id_ticket);
--

go


