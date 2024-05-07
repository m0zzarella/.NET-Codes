create database EmpDB_JOINS

use EmpDB_JOINS


create table deptInfo
(
  deptNo int,
  deptName varchar(20) Not Null,
  deptCity varchar(20)

    constraint pk_deptNo primary key (deptNo)
)

insert into deptInfo values(10,'IT','Kolkata')
insert into deptInfo values(20,'HR','Mumbai')
insert into deptInfo values(30,'Accounts','Chennai')
insert into deptInfo values(40,'Aeronotics','Bangalore')
insert into deptInfo values(50,'Training','Pune')



create table EmployeeInfo

( empNo int,
  empName varchar(20) Not Null,
  empDesignation varchar(20),
  empDeptNo int,
  empSalary bigint Not Null,
 

  --Constraints-- constraint_name which constraint (....)
  constraint pk_empNo primary key (empNo),
  constraint fk_EmployeeInfo_DeptInfo foreign key (empDeptNo) references deptInfo


)


insert into EmployeeInfo 
values (1, 'Mukesh', 'Manager', 10,10000),
       (2, 'Jane', 'HR', 20,5000),
       (3, 'Jerry', 'Developer', 30, 5000),
       (4, 'Norma', 'HR', 10, 7000),
       (5, 'Hoho', 'Developer', 20, 8000)

insert into EmployeeInfo values(6,'Nikhil','Developer',30,15000),		
		(7,'Amay','HR',10,15000),		
		(8,'John','Developer',20,15000),		
		(9,'Amar','HR',30,15000),		
		(10,'Akbar','Developer',10,15001),
		(11,'Anthony','Developer',20,15000),		
	(12,'Naresh','Manager',30,15000)
	
	
select empNo, empName, empDesignation, deptName, deptCity
		   from EmployeeInfo join deptInfo
		   on empDeptNo = deptNo
		   where deptCity = 'Chennai' or deptCity = 'Kolkata'
		   order by deptCity, empName

select deptCity, count(empNo) [Total Strength] from EmployeeInfo join deptInfo
on empDeptNo = deptNo
group by deptCity


Select empName as [Employee Name], CONCAT(lower(empName),'.', SUBSTRING(lower(empDesignation),1,2),'@myorg.co.',SUBSTRING(lower(deptCity),1,2)) as [Email Address] from EmployeeInfo join deptInfo on empDeptNo = deptNo


select * from EmployeeInfo join deptInfo
on deptNo = empDeptNo

select * from EmployeeInfo right join deptInfo
on deptNo = empDeptNo