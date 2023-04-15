

-- uncheck constraint to insert data for table ( ignore contraints ( include: foreign key, ... ) ) 
alter table [table_name] nocheck constraint all

-- verify data against existing data in the table ( enable constraints which is unchecked before )

alter table [table_name] with check check constraint all

-- insert data into a table must sepecify clearly column names because of auto_id function() and constraints
-- e.g:
insert into AGENT(address, name ) values ('', '')