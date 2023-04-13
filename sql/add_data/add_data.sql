

-- uncheck constraint to insert data for table ( ignore contraints ( include: foreign key, ... ) ) 
alter table [table_name] nocheck constraint all

-- verify data againt existing data in the table ( enable constraints which is unchecked before )

alter table [table_name] with check check constraint all

