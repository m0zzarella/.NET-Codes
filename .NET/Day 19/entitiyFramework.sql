create database EmployeeEntityFramework

use EmployeeEntityFramework

	create table employeeInfo
	(
		empNo int primary key,
		empName varchar(20),
		empDesignation varchar(20),
		empSalary int,
		empIsPermenant bit
	)

	insert into employeeInfo values(1,'Nikhil','Consultant',2000,1)
	insert into employeeInfo values(2,'Riya','HR',12000,1)
	insert into employeeInfo values(3,'Jiya','Consultant',22000,0)
	insert into employeeInfo values(4,'Amin','Sales',90000,1)
	insert into employeeInfo values(5,'Surbhi','Consultant',120000,1)

create database BankingDB_EF

use BankingDB_EF

create table BranchInfo 
(branchNo int primary key,
 branchName varchar(20),
 branchLocation varchar(20)
)
insert into BranchInfo values (1, 'North Branch', 'Kashmir'),
(2, 'Centre Branch', 'Delhi'), (3, 'South Branch', 'Chennai'), (4, 'East Branch', 'Kolkata'), (5, 'West Branch', 'Mumbai');

select * from BranchInfo;

create table AccountsInfo
( accNo int primary key,
accName varchar(20),
accType varchar(20),
accBalance bigint,
accIsActive bit,
accBranch int foreign key references BranchInfo

)

insert into AccountsInfo values(1, 'Prayas', 'Savings', 10000, 1, 4),
(2, 'John', 'Savings', 10000, 1, 4),
(3, 'Jane', 'Currents', 10000, 0, 1),
(4, 'Rohit', 'Savings', 10000, 1, 1),
(5, 'Mohit', 'Savings', 10000, 0, 2),
(6, 'Sumit', 'Currents', 10000, 1, 2),
(7, 'Elizabeth', 'Currents', 10000, 1, 3),
(8, 'Margaret', 'Currents', 10000, 1, 3),
(9, 'Mohini', 'Savings', 10000, 1, 5),
(10, 'Rohan', 'Savings', 10000, 0, 5);

create table TransactionInfo
(	 trNo int identity primary key,
     fromAccNo int foreign key references BranchInfo,
	 ToAccNo int foreign key references BranchInfo,
	 amount int,
	 datetime1 datetime
)

INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (1, 4, 1000, '2023-01-15T13:45:30');
INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (2, 3, 1500, '2023-01-16T10:25:00');
INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (3, 5, 750, '2023-01-17T09:10:45');
INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (3, 4, 2500, '2023-01-18T16:30:15');
INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (6, 3, 800, '2023-01-19T14:05:30');
INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (5, 2, 1250, '2023-01-20T11:23:25');
INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (2, 1, 940, '2023-01-21T18:40:00');
INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (4, 3, 670, '2023-01-22T12:15:45');
INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (5, 2, 3000, '2023-01-23T08:30:15');
INSERT INTO TransactionInfo (fromAccNo, ToAccNo, amount, datetime1) VALUES (5, 4,1200, '2023-01-24T17:45:30');

alter table BranchInfo add branchEmail varchar(20) 

select * from BranchInfo

