create database EmployeeManagementDB2

use EmployeeManagementDB2

create table EmployeeDetails

( empNo int,
  empName varchar(20) Not Null,
  empDesignation varchar(20),
  empDeptNo int,
  empSalary bigint Not Null,
  empisActive bit not null
  

  --Constraints-- constraint_name which constraint (....)
  constraint pk_empNo primary key (empNo),
  constraint check_empDesignation check (empDesignation in ('Manager', 'Developer', 'HR')),
  constraint check_empSalary check (empSalary between 5000 and 25000),

)


create table deptInfo
(
  deptNo int,
  deptName varchar(20) Not Null,
  deptCity varchar(20)

    constraint pk_deptNo primary key (deptNo),
	constraint unk_deptName unique (deptName),
	constraint fk_deptInfo_Employee foreign key (deptNo) references EmployeeDetails


)


insert into EmployeeDetails 
values (10, 'Name1', 'Manager', 10,10000, 1),
       (20, 'Name2', 'HR', 20,5000, 0),
       (30, 'Name3', 'Developer', 30, 5000, 1),
       (40, 'Name24', 'HR', 40, 7000, 1),
       (50, 'Name21', 'Developer', 50, 8000, 1)

insert into EmployeeDetails values(1,'Nikhil','Developer',10,15000,1),		
		(2,'Amay','HR',20,15000,1),		
		(3,'John','Developer',10,15000,1),		
		(4,'Amar','HR',20,15000,1),		
		(5,'Akbar','Developer',10,15000,1),
		(6,'Anthony','Developer',10,15000,0),		
	(7,'Naresh','Manager',40,15000,1),
	(8,'Suresh','Developer',10,15000,1),	
	(9,'Ramesh','Manager',50,15000,1);

	insert into EmployeeDetails values(60,'Nikhilesh','Developer',10,15000,1);
	

insert into DeptInfo values(10,'IT','Kolkatta')
insert into DeptInfo values(20,'HR','Mumbai')
insert into DeptInfo values(30,'Accounts','Chennai')
insert into DeptInfo values(40,'Sales','Pune')
insert into DeptInfo values(50,'Transport','Bangalore')



		--DQL

		--1. Select all the data, with all the columns
		select * from EmployeeDetails

		--2. select all the data with limited columns / columns you want to see / display / read 
		select empNo,empName, empDesignation,empSalary from EmployeeDetails

		--3. select data with column alias, proper column heading
		select empNo as [Employee No],  --use a square bracket if you have a space in column name
			  empName as [First Name],
			  empDesignation as [Working As],
			  empSalary as Salary
			  from EmployeeDetails

		--4. select with concatination / form a redable statement
			select empName + ' is a ' + empDesignation as [Employee Details]from EmployeeDetails

	    --5. select with filter / search -- we use a where clause
		select * from EmployeeDetails where empDesignation = 'HR'  --this will show me only HR records
		select * from EmployeeDetails where empDesignation = 'Developer'  --this will show me only HR records

		select * from EmployeeDetails where empDesignation = 'Developer' and empIsActive =1 --this will show me only HR records

						select * from EmployeeDetails where empDeptNo = 10 	   or empDeptNo = 40

select empNo, empName, empDesignation from EmployeeDetails order by empDesignation

select empNo, empName, empDesignation from EmployeeDetails order by empDesignation, empName

select empName, upper(empName) as [Capitalised] from EmployeeDetails
select empName, lower(empName) as [Smaller Case] from EmployeeDetails
select empName, substring(empName, 1, 3) from EmployeeDetails

Select empName, CONCAT(lower(empName),'@myorganization.co.',SUBSTRING(lower(empDesignation),1,2)) as [Email Address] from EmployeeDetails

select sum(empSalary) as [Total Salary], min(empSalary) as [Min Salary], max(empSalary) as [Max Salary], avg(empSalary) as [Average Salary] from EmployeeDetails

select sum(empSalary) as [Total Developer Salary]  from EmployeeDetails where empDesignation = 'Developer'
select sum(empSalary) as [Total HR Salary]  from EmployeeDetails where empDesignation = 'HR'
select sum(empSalary) as [Total Manager Salary]  from EmployeeDetails where empDesignation = 'Manager'

select sum(empNo) as [Total Developer]  from EmployeeDetails where empDesignation = 'Developer'
select sum(empNo) as [Total HR ]  from EmployeeDetails where empDesignation = 'HR'
select sum(empNo) as [Total Manager]  from EmployeeDetails where empDesignation = 'Manager'

select empDesignation as [Designation], sum(empSalary) as [Employee Salary] from EmployeeDetails group by empDesignation  

select * from EmployeeDetails

create view v_empDetails
as select empNo as [Employee Number],
empName as [Name],
empDesignation as [Designation],
empSalary as [Monthly Pay]
from EmployeeDetails

select * from v_empDetails

create view v_empEmail1
as select empName as [Employee Name], 
CONCAT(lower(empName),'.',SUBSTRING(lower(empDesignation),1,2),'@myorganization.co.',SUBSTRING(lower(deptCity),1,2)) as [Email Address] from EmployeeDetails join deptInfo on empDeptNo = deptNo

select * from v_empEmail1


