use BusManagement

go;
-- auto id
create function func_auto_id_bus() returns varchar(20) begin
declare @id_no varchar(20)
set @id_no = (
        select max(id_bus)
        from BUS
    ) if @id_no is null
set @id_no = concat('bus_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1 return concat('bus_', @no);
end
go;
--
create function func_auto_id_trip() returns varchar(20) begin
declare @id_no varchar(20)
set @id_no = (
        select max(id_trip)
        from TRIP
    ) if @id_no is null
set @id_no = concat('tri_', '0000000000')
declare @no int
set @no = right(@id_no, 10) + 1 return concat('tri_', @no)
end

go;