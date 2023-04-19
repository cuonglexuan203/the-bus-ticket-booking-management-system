use BusManagement;

go
-- auto id
CREATE function [dbo].[func_auto_id_account]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_account)
    from SYSTEMACCOUNT
)
if( @id_no is null)
    set @id_no = concat('acc_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('acc_', format(@no, '0000000000'))
end
GO

--

CREATE function [dbo].[func_auto_id_agent]()
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
return concat('age_', format(@no, '0000000000'))
end
GO


--

CREATE function [dbo].[func_auto_id_booking]()
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
return concat('boo_', format(@no, '0000000000'))
end
GO

--

CREATE function [dbo].[func_auto_id_bus]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_bus)
    from BUS
)
if( @id_no is null)
    set @id_no = concat('bus_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('bus_', format(@no, '0000000000'))
end
GO

--

CREATE function [dbo].[func_auto_id_busroute]()
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
return concat('br_', format(@no, '0000000000'))
end
GO

--


CREATE function [dbo].[func_auto_id_busstation]()
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
return concat('bs_', format(@no, '0000000000'))
end
GO

--

CREATE function [dbo].[func_auto_id_cashreserve]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_cash_reserve)
    from CASHRESERVE
)
if( @id_no is null)
    set @id_no = concat('cr_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('cr_', format(@no, '0000000000'))
end
GO

--

CREATE function [dbo].[func_auto_id_employee]()
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
return concat('emp_', format(@no, '0000000000'))
end
GO

--

CREATE function [dbo].[func_auto_id_event]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_event)
    from EVENT
)
if( @id_no is null)
    set @id_no = concat('eve_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('eve_', format(@no, '0000000000'))
end
GO

--

CREATE function [dbo].[func_auto_id_package]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_package)
    from PACKAGE
)
if( @id_no is null)
    set @id_no = concat('pac_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('pac_', format(@no, '0000000000'))
end
GO

--
CREATE function [dbo].[func_auto_id_passenger]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_passenger)
    from PASSENGER
)
if( @id_no is null)
    set @id_no = concat('pas_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('pas_', format(@no, '0000000000'))
end
GO
--
--CREATE function [dbo].[func_auto_id_place]()
--returns char(20)
--as
--begin
--declare @id_no char(20)
--set @id_no = (
--    select max(id_place)
--    from PLACE
--)
--if( @id_no is null)
--    set @id_no = concat('pla_', '0000000000')
--declare @no int
--set @no = right(@id_no, 10) + 1;
--return concat('pla_', format(@no, '0000000000'))
--end
--GO

--

CREATE function [dbo].[func_auto_id_policy]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_policy)
    from PACKAGEPRICEPOLICY
)
if( @id_no is null)
    set @id_no = concat('pol_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('pol_', format(@no, '0000000000'))
end
GO

--

CREATE function [dbo].[func_auto_id_position]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_position)
    from POSITION
)
if( @id_no is null)
    set @id_no = concat('pos_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('pos_', format(@no, '0000000000'))
end
GO

--
CREATE function [dbo].[func_auto_id_privilege]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_privilege)
    from PRIVILEGE
)
if( @id_no is null)
    set @id_no = concat('pri_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('pri_', format(@no, '0000000000'))
end
GO

--

create function dbo.func_auto_id_packagepricepolicy()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_policy)
    from PACKAGEPRICEPOLICY
)
if( @id_no is null)
    set @id_no = concat('pol_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('pol_', format(@no, '0000000000'))
end

go

--


--

CREATE function [dbo].[func_auto_id_refund]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_refund)
    from REFUND
)
if( @id_no is null)
    set @id_no = concat('ref_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('ref_', format(@no, '0000000000'))
end
GO

--

CREATE function [dbo].[func_auto_id_ticket]()
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
return concat('tic_', format(@no, '0000000000'))
end
GO
--

CREATE function [dbo].[func_auto_id_trip]()
returns char(20)
as
begin
declare @id_no char(20)
set @id_no = (
    select max(id_trip)
    from TRIP
)
if( @id_no is null)
    set @id_no = concat('tri_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1;
return concat('tri_', format(@no, '0000000000'))
end
GO


