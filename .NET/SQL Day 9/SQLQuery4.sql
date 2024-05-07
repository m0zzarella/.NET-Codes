create database AirlineDB

use AirlineDB

create table FlightSchedules

( routeNo int not null,
  sourceName varchar(20) Not Null,
  destinationName varchar(20),
  flightFare bigint Not Null,


  --Constraints-- constraint_name which constraint (....)
  constraint pk_routeNo primary key (routeNo),
  constraint check_source check (sourceName in ('Mumbai', 'Pune', 'Chennai', 'Kolkata', 'Goa', 'Bangalore')),
  constraint check_destination check (destinationName in ('Mumbai', 'Pune', 'Chennai', 'Kolkata', 'Goa', 'Bangalore')),
  constraint flightFare check (flightFare between 1800 and 18000),
)

----------------------------

insert into FlightSchedules values(101, 'Kolkata', 'Pune', 10000)
insert into FlightSchedules values(102, 'Mumbai', 'Chennai', 12000)
insert into FlightSchedules values(103, 'Goa', 'Kolkata', 5000)
insert into FlightSchedules values(104, 'Bangalore', 'Pune', 6000)
insert into FlightSchedules values(105, 'Goa', 'Pune', 7000)




create table PassengerInfo
(PNRno bigint not null,
 firstName varchar(20) not null,
 lastName varchar(20) not null,
 flightNo int not null
 
 --Constraints


constraint pk_PnrNo primary key (PNRno),
constraint chk_firstName check (len(firstName) >= 3),
constraint chk_LastName check (len(lastName) >= 3),
constraint fk_PassengerInfo_FlightSchedule foreign key (flightNo) references FlightSchedules

)


insert into PassengerInfo values(12012, 'Prayas', 'Sanyal', 101)
insert into PassengerInfo values(12013, 'John', 'Doe', 102)
insert into PassengerInfo values(12014, 'Jane', 'Doe', 101)
insert into PassengerInfo values(12019, 'Hahah', 'Hoho', 103)




create table PassengerDetails
(  passengerNo int primary key not null,
   PNRNo bigint not null,
   EmailAddress varchar(20) not null,
   mobileNo bigint not null,
   PANno varchar(10) not null,
   AddressN varchar(200) not null,

   ------
   constraint fk_PassengerDetails_PassengerInfo foreign key(PNRNo) references PassengerInfo


)

