create table PASSENGERACCOUNT(
	username varchar(30) primary key,
	password varchar(30) not null,
	id_passenger char(20)
);
alter table PASSENGERACCOUNT add constraint FK_passengeraccount_id_passenger foreign key (id_passenger) references  PASSENGER(id_passenger);