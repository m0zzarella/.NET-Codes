create database empDB_DataAnnotation

use empDB_DataAnnotation

create table empInfo
(
	empNo int primary key,
	empName varchar(20) not null,
	empDesigantion varchar(20) not null,
	empSalary int not null,
	empIsPermenant bit not null,
	empEmail varchar(50) not null,

	constraint chk_nameLength check (len(empName) between 3 and 20),
	constraint chk_salary check (empSalary between 8000 and 25000)
)
insert into empInfo values(101,'Nikhil','Trainer',9000,1,'nik@hotmail.com')
insert into empInfo values(102,'Aarti','Sales',9000,1,'aarti@hotmail.com')
insert into empInfo values(103,'Zoya','Trainer',19000,1,'zoya@hotmail.com')
insert into empInfo values(104,'Fahad','Accounts',13000,1,'fahad@hotmail.com')
insert into empInfo values(105,'Manish','Trainer',9000,1,'manish@hotmail.com')