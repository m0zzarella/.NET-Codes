-----creation
create database BankingDB_Practice;


use BankingDB_Practice;

 
create table BranchInfo 
(
    branchNo int primary key, 
    branchName varchar(20) NOT NULL, 
    branchCity varchar(20) NOT NULL, 
    branchEmail varchar(20) NOT NULL
);
 

insert into BranchInfo 
values (10, 'SaltLake', 'Kolkata', 'branch1@bank.com'),
       (20, 'HiTech City', 'Hyderabad', 'branch2@bank.com'),
       (30, 'WestBranch', 'Mumbai', 'branch3@bank.com'),
       (40, 'CapitalBranch', 'Delhi', 'branch4@bank.com'),
       (50, 'SouthBranch', 'Chennai', 'branch5@bank.com')
 
--drop table BranchInfo


create table CustomerInfo 
(
    customerNo int primary key identity(10,10), 
    customerName varchar(20) NOT NULL,
    accountType varchar(20) NOT NULL, 
    accountBalance bigint NOT NULL, 
    branchNo int,

	constraint check_accountType  check (accountType in ('Savings', 'Current', 'PF')),
	constraint check_accountBalance check (accountBalance >= 0),
	constraint fk_CustomerInfo_BranchInfo foreign key (branchNo) references BranchInfo
)
 


insert into CustomerInfo (customerName, accountType, accountBalance, branchNo)
VALUES ('John', 'Savings', 20000, 10),
       ('Jerry', 'Current', 25000, 10),
       ('Joe', 'PF', 30000, 10),
       ('Rohan', 'Savings', 20000, 20),
       ('Mohan', 'Current', 25000, 20),
       ('Mohit', 'PF', 30000, 20),
       ('Jake', 'Savings', 20000, 30),
       ('Jane', 'Current', 25000, 30),
       ('Shane', 'PF', 30000, 30),
       ('Customer10', 'Savings', 20000, 40),
       ('Customer11', 'Current', 25000, 40),
       ('Customer12', 'PF', 30000, 40),
       ('Customer13', 'Savings', 20000, 50),
       ('Customer14', 'Current', 25000, 50),
       ('Customer15', 'PF', 30000, 50);
 
SELECT * 
FROM CustomerInfo 
JOIN BranchInfo 
ON CustomerInfo.branchNo = BranchInfo.branchNo;