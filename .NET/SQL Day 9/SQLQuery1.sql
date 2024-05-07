create database EmployeeManagementDB

use EmployeeManagementDB

create table EmployeeDetails

( empNo int,
  empName varchar(20) Not Null,
  empDesignation varchar(20),
  empSalary bigint Not Null,
  empPan varchar(10),
  empisPermanent bit,
  empDeptNo int

  --Constraints-- constraint_name which constraint (....)
  constraint pk_empNo primary key (empNo),
  constraint check_empDesignation check (empDesignation in ('Manager', 'Developer', 'HR')),
  constraint check_empSalary check (empSalary between 5000 and 25000),
  constraint unk_Pan unique (empPan)
)

insert into EmployeeDetails values (101, 'John', 'Manager', 5000, 'SRFP231', 1, 10)
insert into EmployeeDetails values (102, 'Jane', 'Developer', 11000, 'SEFP231', 1, 10)
insert into EmployeeDetails values (103, 'Joe', 'Manager', 21000, 'SRFP431', 1, 10)
insert into EmployeeDetails values (104, 'Jake', 'HR', 5500, 'SRFP221', 1, 10)
insert into EmployeeDetails values (105, 'Jeep', 'HR', 15000, 'SRFP241', 1, 10)

select * from EmployeeDetails

delete from EmployeeDetails where empNo = 105

alter table EmployeeDetails add constraint chk_EmpName_len check (len(EmpName) between 3 and 20)
