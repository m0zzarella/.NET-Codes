create database BankingDB_SQL

use BankingDB_SQL

create table BranchInfo
(
  BranchNo int not null,
  BranchName varchar(20) Not Null,
  BranchCity varchar(20) Not null

  constraint check_branchCity check (BranchCity in ('Kolkata', 'Mumbai', 'Pune')),
  )

  insert into BranchInfo values(10, 'Branch1', 'Kolkata'), 
  (20, 'Branch2', 'Kolkata'),
  (30, 'Branch3', 'Mumbai'),
  (40, 'Branch4', 'Mumbai'),
  (50, 'Branch5', 'Pune'),
  (60, 'Branch6', 'Pune');

  alter table BranchInfo drop constraint check_branchCity 
  alter table BranchInfo add constraint check_branchCity check (BranchCity in ('Kolkata', 'Mumbai', 'Pune', 'Bangalore', 'Chennai'))
  
  alter table BranchInfo add constraint pk_branchNo primary key (BranchNo)

  create table accountInfo

( accNo int identity (500,1) Not Null,
  accName varchar(20) Not Null,
  accType varchar(20) Not Null,
  accBalance bigint Not Null,
  accIsActive bit Not Null,
  accBranch int Not Null,


  --Constraints-- constraint_name which constraint (....)
  constraint pk_accNo primary key (accNo),
  constraint check_accType check (accType in ('Savings', 'Current', 'PF')),
  constraint chk_accName_len check (len(accName)>3),
   constraint chk_accBalance check (accBalance between 100 and 1000000),
constraint fk_accountInfo_BranchInfo foreign key (accBranch) references BranchInfo
)

insert into accountInfo (accName, accType, accBalance, accIsActive, accBranch)
values 
('John', 'Savings', 60000, 1, 10),
('Emma', 'Current', 23000, 1, 20),
('Robert', 'PF', 100000, 0, 30),
('Anna', 'Savings', 45000, 1, 30),
('James', 'Current', 40000, 1, 50),
('Mary', 'Savings', 78500, 1, 20),
('Richard', 'PF', 89000, 1, 10),
('Jessica', 'Savings', 13000, 0, 30),
('Charles', 'PF', 600000, 1, 40),
('Linda', 'Savings', 187000, 1, 50),
('Michael', 'Current', 78000, 0, 10),
('Christina', 'Savings', 91000, 1, 20),
('Daniel', 'PF', 25800, 1, 30),
('Nicole', 'Savings', 48900, 1, 40),
('Anthony', 'PF', 30000, 1, 50),
('Sarah', 'Savings', 34300, 1, 10),
('William', 'Current', 29000, 0, 20),
('Elizabeth', 'Savings', 64000, 1, 30),
('David', 'PF', 20900, 1, 40),
('Emma', 'Current', 10800, 1, 50);

alter table accountInfo alter column accBranch int

insert into accountInfo (accName, accType, accBalance, accIsActive, accBranch)
values 
('Jenny', 'Current', 29000, 0, NULL),
('Jerry', 'Savings', 64000, 1, NULL),
('Jono', 'PF', 20900, 1, NULL),
('Mohan', 'Current', 10800, 1, NULL);

select * from BranchInfo
select * from accountInfo

select accNo, accName, accBalance from accountInfo

select * from accountInfo where accType = 'Savings'

select * from accountInfo where accType = 'Savings' or accType = 'PF'

select * from accountInfo where accType = 'Savings' and accBalance > 100000

select * from accountInfo where SUBSTRING(accName, 1, 1) = 'C'

select * from accountInfo order by accType

select * from accountInfo order by accType, accName

select * from accountInfo order by accType, accNo, accName

select accNo, accName, accType, accBalance from accountInfo where accBalance =(select max(accBalance) as [Maximum Balance] from accountInfo)

select count(accNo) as [Total Accounts], accBalance	from accountInfo


SELECT accNo, accBalance as CurrentBalance, accBalance * 0.1 AS Interest, accBalance + (accBalance * 0.1) AS FutureBalance 
FROM accountInfo;

SELECT b.BranchName, COUNT(a.accNo) AS NumberOfAccounts 
FROM accountInfo a
JOIN BranchInfo b ON a.accBranch = b.BranchNo
GROUP BY b.BranchName;

select getdate()
select datepart	(DAYOFYEAR,GETDATE())

select dateadd(month,4,GETDATE())

select DATEDIFF(week,'2024-03-01','2025-02-02')

select dateadd(day,55,'2024-03-01') as [Last Day of Training]

select dateadd(month,6,'2024-03-01') as [Meeting Date]

select dateadd(month,12,'2024-03-01') as [Appraisal Meeting]

select dateadd(month,18,'2024-03-01') as [Joining Bonus]

select dateadd(week,4,'2024-03-01') as [Promotion Letter]

select * from accountInfo

delete from accountInfo where accNo = 501 or accNo = 502

delete from accountInfo where accBranch in (select BranchNo from BranchInfo where BranchCity = 'Pune')

select * from accountInfo
update accountInfo set accBalance = accBalance + 500
select * from accountInfo
















