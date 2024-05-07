create database BankingDB

use BankingDB

create table accountDetails

( accNo int Not Null,
  accName varchar(20) Not Null,
  accType varchar(20) Not Null,
  accBalance bigint Not Null,
  accIsActive bit Not Null,
  accBranch int Not Null,
  accPan varchar(20)

  --Constraints-- constraint_name which constraint (....)
  constraint pk_accNo primary key (accNo),
  constraint check_accType check (accType in ('Savings', 'Current', 'PF')),
  constraint check_accBranch check (accBranch in (10,20,30)),
  constraint chk_accName_len check (len(accName)>3),
  constraint unk_accPan unique (accPan)
)

insert into accountDetails values (101, 'John', 'Savings', 5000, 1, 10, 'SRFP231')
insert into accountDetails values (102, 'Jane', 'Current', 11000, 1, 20, 'SRDP231')
insert into accountDetails values (103, 'Joe', 'Current', 21000, 1, 30, 'SRFP931')
insert into accountDetails values (104, 'Jake', 'Savings', 5500, 1, 20, 'KRFP531')
insert into accountDetails values (105, 'Jeep', 'Current', 15000, 0, 10, 'MRFP251')

select * from accountDetails