create database insuranceDB_SP_LINQ

use insuranceDB_SP_LINQ

create table policyDetails
( policyNo int primary key,
  policyName varchar(30),
  policyPremium bigint check (policyPremium between 5000 and 50000)
 )

 insert into policyDetails values (1, 'HDFC Premium', 10000),
 (2, 'Max Life', 15000),
 (3, 'Tata AIA Life', 20000),
 (4, 'Prudential', 11000),
 (5, 'Bajaj Allianz', 7000);

 --a. get all data
 create procedure proc_getAllData 
 as
 begin 
	select * from policyDetails
 end

 exec proc_getAllData

 --b. get by policy no
 create procedure proc_getDataByPNo (@pNo int)
 as
 begin
	select * from policyDetails where policyNo = @pNo
 end

 --c. get by policy name

  create procedure proc_getDataByPName (@pName varchar(30))
 as
 begin
	select * from policyDetails where policyName = @pName
 end


 --d get policy between range  8000 and 12000

 create procedure proc_getRangePolicy (@range1 bigint, @range2 bigint)
as
begin
	select * from policyDetails where policyPremium between @range1 and @range2
end

exec proc_getRangePolicy 5000, 15000

--e insert a new policy

create procedure proc_InsertNewPolicy (@pNo int, @pName varchar(30), @pPrem bigint)
as
begin
 insert into policyDetails values(@pNo, @pName, @pPrem)
end

exec proc_InsertNewPolicy 6, 'Max Life', 40000 

--f edit policy premium by name

create procedure proc_editPremium (@newPremium bigint, @pName varchar(30))
as
begin
 update policyDetails set policyPremium = @newPremium where policyName = @pName
end

exec proc_editPremium 35000, 'Max Life'

--g Delete Policy by Policy Number

create procedure proc_deletePolicy (@pNo int)
as
begin
delete from policyDetails where policyNo = @pNo
end

exec proc_getAllData
