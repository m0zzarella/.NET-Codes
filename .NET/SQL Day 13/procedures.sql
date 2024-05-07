create database learning_procedures

use learning_procedures

create table deptInfo
( deptNo int primary key,
  deptName varchar(20),
  deptCity varchar(20)

)

create procedure proc_newDept(@dNo int, @dName varchar(20), @dCity varchar(20))
as
begin
  insert into deptInfo values(@dNo, @dName, @dCity)
end

exec proc_newDept 10, 'HR', 'Kolkata'

create procedure proc_deptUpdate(@dNo int, @newdeptName varchar(20))
as
begin
  update deptInfo set deptName = @newdeptName where deptNo = @dNo
end

select * from deptInfo

exec proc_deptUpdate 10, 'HR Manager'


	create table loginInfo
	(
		userName varchar(20) primary key,
		password varchar(20),
		acStatus varchar(20),
		attempts int
	)
	drop table loginInfo


	create procedure proc_NewLogin(@userName varchar(20),@pwd varchar(20))
	as
	begin
		declare @countUName int;
		set @countUName = (select count(userName) from loginInfo) -- this will return int
		if (@countUName = 1)
		begin
			--throw new exception 
			print 'Username already exist please choose a different name';
		end
		else
		begin
		insert into logininfo values(@userName,@password,'New',0)
		end
	end