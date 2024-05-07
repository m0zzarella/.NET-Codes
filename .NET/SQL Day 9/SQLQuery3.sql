
use EmployeeManagementDB
create table EmployeeInfo

( empNo int not null,
  empName varchar(20) Not Null,
  empDesignation varchar(20),
  empSalary bigint Not Null,

  empisPermanent bit not null,
  empDeptNo int not null

  --Constraints-- constraint_name which constraint (....)
  constraint pk_empNo2 primary key (empNo),
  constraint check_empSalary2 check (empSalary between 5000 and 25000),
  constraint chk_EmpName_len2 check (len(EmpName) between 3 and 20)

)
