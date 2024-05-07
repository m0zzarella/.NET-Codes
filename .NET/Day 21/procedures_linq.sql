create database empDB_SP

use empDB_SP

create table deptInfo
(deptNo int primary key,
 deptName varchar(20),
 deptCity varchar(20)
 )
 insert into deptInfo values(10, 'HR', 'Mumbai'),
                            (20, 'Accounts', 'Delhi'),
							(30, 'IT', 'Kolkata'),
							(40, 'Sales', 'Chennai'),
							(50, 'Transport', 'Paris');
--1 select procedure to show all the data
create procedure proc_AllDept
as
begin
select * from deptInfo
end

exec proc_AllDept

--2 select data based on DPno

create procedure proc_DeptInfo(@dNo int)
as 
begin
select * from deptInfo where deptNo = @dNo
end

exec proc_DeptInfo 20

--3 select data based on DeptLoc

create procedure proc_deptbyLocation(@dCity varchar(20))
as
begin
select * from deptInfo where deptCity = @dCity
end

exec proc_deptbyLocation Kolkata




--4 SP to Insert New Data 

create procedure proc_InsertNewDept(@dNo int, @dName varchar(20), @dCity varchar(20))
as
begin
	   insert into deptInfo values (@dNo, @dName, @dCity)
end

exec proc_InsertNewDept 60, 'Transport', 'Kolkata'

exec proc_AllDept

--5. SP to delete the data by dept no:

create procedure proc_deleteDept(@deptNo int)

as
begin
		delete from deptInfo where deptNo = @deptNo
end

exec proc_deleteDept 60

--6. SP to update dept Name by dept number

create procedure proc_EditDeptName(@dNo int, @newDeptName varchar(20))
as
begin
	update deptInfo set deptName = @newDeptName where deptNo = @dNo
end

exec proc_EditDeptName 50,'Cafeteria'

--------------------------------------------------------------------------------------
create database flightDB_SP

use flightDB_SP

create table flightInfo
(
	flightNo int primary key,
	flightSourceCity varchar(20),
	flightDestinationCity varchar(20),
	flightStatus varchar(20) check (flightStatus in ('Scheduled', 'Completed', 'In Progress', 'Cancelled')),
	flightFare int
)

insert into flightInfo values(10, 'Kolkata', 'Delhi', 'Scheduled', 5600),
                             (20, 'Paris', 'London', 'Completed', 25600),
							 (30, 'Boston', 'Athens', 'In Progress', 75600),
							 (40, 'Doha', 'Rome', 'Scheduled', 15600),
							 (50, 'Delhi', 'Hyderabad', 'Cancelled', 8600);



-- 1. Select all the records from the table

create procedure proc_SelectAllData
as
begin
	select * from flightInfo
end

exec proc_SelectAllData


--2 select data based on flightno

create procedure proc_FlightInfofNo(@fNo int)
as 
begin
select * from flightInfo where flightNo = @fNo
end

exec proc_FlightInfofNo 20

 --3. SP to delete the data by flight no:

create procedure proc_deleteFlight(@flightNo int)

as
begin
		delete from flightInfo where flightNo = @flightNo
end

exec proc_deleteFlight 40

--4. SP to update flight Status by flight number

create procedure proc_EditflightStatus(@fNo int, @newflightStatus varchar(20))
as
begin
	update flightInfo set flightStatus = @newflightStatus where flightNo = @fNo
end

--5 select data based on flightSource and Destination

create procedure proc_FlightSourceDestination(@fSource varchar(20), @fDestination varchar(20))
as 
begin
select * from flightInfo where flightSourceCity = @fSource and flightDestinationCity = @fDestination
end

exec proc_FlightSourceDestination  'Kolkata', 'Delhi'


--6 SP to Insert New Flight Data 

create procedure proc_InsertNewFlight(@fNo int, @fSource varchar(20), @fDest varchar(20), @fStatus varchar(20), @fFare int)
as
begin
	   insert into flightInfo values (@fNo, @fSource, @fDest, @fStatus, @fFare)
end

exec proc_InsertNewFlight 40, 'New York', 'Boston', 'Cancelled', 10000

exec proc_SelectAllData













