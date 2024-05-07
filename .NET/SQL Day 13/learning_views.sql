create database learning_views

use learning_views

create table AccountInfoPS
( accNo int Not Null,
  accName varchar(20) Not Null,
  accType varchar(20) Not Null,
  accBalance bigint Not Null,
  accIsActive bit Not Null,
  accBranch int Not Null,

  constraint pk_accNo primary key (accNo)
)

create table BranchInfo 
(
    branchNo int, 
    branchName varchar(20) NOT NULL, 
    branchCity varchar(20) NOT NULL

    constraint pk_branchNo primary key (branchNo)
)

insert into BranchInfo 
values (10, 'East Branch', 'Kolkata'),
       (20, 'West Branch', 'Mumbai'),
       (30, 'Centre Branch', 'Delhi');

alter table AccountInfoPS drop constraint pk_accNo

alter table AccountInfoPS add constraint pk_accNo primary key (accNo)



insert into AccountInfoPS (accNo,accName, accType, accBalance, accIsActive, accBranch)
VALUES (1, 'John', 'Savings', 20000, 1, 10),
       (2, 'Jerry', 'Current', 25000, 0, 20),
       (3, 'Joe', 'PF', 30000, 1, 30),
       (4, 'Rohan', 'Savings', 20000, 1, 40),
       (5, 'Mohan', 'Current', 25000, 1, 50),
       (6, 'Mohini', 'PF', 30000, 1, 60),
       (7, 'Jake', 'Savings', 20000, 0, 70),
       (8, 'Jane', 'Current', 25000, 1, 80),
       (9, 'Shane', 'PF', 30000, 1, 90),
       (10, 'Elizabeth', 'Savings', 20000, 0, 100);

 create view  v_futureBalance
 as select accNo as [Account No.], accName as [Account Name], accBalance as [Present Balance], accBalance*0.05 as [Interest],
 accBalance+(accBalance*0.05) as [Future Balance] from AccountInfoPS

 select * from v_futureBalance

create view v_lessBalance
as select accNo as [Account No], accName as [Account Name] from AccountInfoPS where accBalance<28000

select * from v_lessBalance

create view v_savingsDetails1
as select accNo as [Account No.], accName as [Account Name], accType as [Account Type], accBalance as [Account Balance], accIsActive as [Status] from AccountInfoPS where accType = 'Savings'
   
select * from v_savingsDetails1

create view v_total_accounts as
SELECT b.branchName, COUNT(a.accNo) as TotalAccounts
FROM AccountInfoPS a
INNER JOIN BranchInfo b ON a.accBranch = b.branchNo
GROUP BY b.branchName;

select * from v_total_accounts