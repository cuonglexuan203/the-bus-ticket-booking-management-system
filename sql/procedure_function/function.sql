use BusManagement;

go
-- auto id
create function dbo.func_auto_id_bus() returns varchar(20) begin
declare @id_no char(20)
set @id_no = (
        select max(id_bus)
        from BUS
    ) 
if @id_no is null
    set @id_no = concat('bus_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1
return concat('bus_', @no);
end

go
--
create function dbo.func_auto_id_trip() returns varchar(20) begin
declare @id_no char(20)
set @id_no = (
        select max(id_trip)
        from TRIP
    ) 
if @id_no is null
    set @id_no = concat('tri_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1
return concat('tri_', @no)
end

go

--

create function dbo.func_auto_id_ticket()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_ticket)
    from TICKET
)
if( @id_no is null)
    set @id_no = concat('tic_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('tic_', @no)
end

go

--
create function dbo.func_auto_id_agent()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_agent)
    from AGENT
)
if( @id_no is null)
    set @id_no = concat('age_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('age_', @no)
end

go

--

create function dbo.func_auto_id_employee()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_employee)
    from EMPLOYEE
)
if( @id_no is null)
    set @id_no = concat('emp_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('emp_', @no)
end

go

--

create function dbo.func_auto_id_busroute()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_route)
    from BUSROUTE
)
if( @id_no is null)
    set @id_no = concat('br_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('br_', @no)
end

go

--
create function dbo.func_auto_id_booking()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_booking)
    from BOOKING
)
if( @id_no is null)
    set @id_no = concat('boo_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('boo_', @no)
end

go

--
create function dbo.func_auto_id_place()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_place)
    from PLACE
)
if( @id_no is null)
    set @id_no = concat('pla_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('pla_', @no)
end

go

--
create function dbo.func_auto_id_busstation()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_bus_station)
    from BUSSTATION
)
if( @id_no is null)
    set @id_no = concat('bs_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('bs_', @no)
end

go

--
