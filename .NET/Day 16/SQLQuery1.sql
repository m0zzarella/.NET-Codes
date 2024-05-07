



create database EmployeeManagementDB
use EmployeeManagementDB;
 
 
create table deptInfo
(
	deptNo int primary key,
	deptName varchar(20),
	deptCity varchar(20)
)
 
insert into deptInfo values(10,'IT','Kolkata');
insert into deptInfo values(20,'HR','Mumbai');
insert into deptInfo values(30,'Sales','Pune');
insert into deptInfo values(40,'Accounts','Chennai');

select * from deptInfo

update deptInfo set deptName = 'Manager' where deptCity = 'Kolkata'