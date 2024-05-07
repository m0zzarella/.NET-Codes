create database learning_functions

use database learning_functions

create function greetuser(@GuestName varchar(20)) returns varchar(50)
as
begin 
 -- coding
  return 'Hello and Welcome to TSQL' + @GuestName
end

select dbo.greetuser(' Ravi ') as Greet


create function calculateNumbers(@num1 int, @num2 int, @action varchar(20)) returns int
as
begin
return @num1 + @num2
end

select dbo.calculateNumbers(30,40,'add') as Addition

alter function 	calculateNumbers(@num1 int, @num2 int, @action varchar(20)) returns int
as
begin

if(@action = 'Add')
begin
 		return @num1 + @num2
end

else if(@action = 'Sub')
begin
 		return @num1 - @num2
end

else if(@action = 'Mul')
begin
 		return @num1*@num2
end

else if(@action = 'Div')
begin
 		return @num1/@num2
end
 return 0 
end

select dbo.calculateNumbers(20,10,'Div') as Division

create function userLogin (@username varchar(20), @password varchar(20)) returns varchar(20)
as
begin

if(@username = 'Admin' and @password = 'Admin@1234') 

begin 
return 'Login Succesfull'
end

else
begin
return 'Invalid Login'
end

return 0 
end

select dbo.userLogin('Admin','Admin@1234') as [LoginStatus]

select dbo.userLogin('Admin','Admin@21234') as [LoginStatus]

alter function CalculateCTC(@empExperienced bit, @empCity varchar(20)) returns bigint
as
begin
declare @basicSalary int; declare @HRA int; declare @monthlyBonus int; declare @Gross int; declare @NET int; declare @CTC int;  declare @tax int;
set @monthlyBonus = 1500;

if(@empExperienced = 1)
begin
set @basicSalary = 8000;

if(@empCity = 'Mumbai')
begin
set @HRA = 0.30 * @basicSalary; 
end

else if(@empCity = 'Pune')
begin
set @HRA = 0.2 * @basicSalary; 
end

else if(@empCity = 'Kolkata')
begin
set @HRA = 0.2 * @basicSalary; 
end

else if(@empCity = 'Chennai')
begin
set @HRA = 0.15 * @basicSalary; 
end

set @Gross = @basicSalary + @HRA + @monthlyBonus;
   set @tax = 0.08 * @Gross;

	set @NET = @Gross - @tax;
	set @CTC = @NET*12;
	return @CTC;
end

else if (@empExperienced = 0)
begin
set @basicSalary = 5000;
if(@empCity = 'Mumbai')
begin
set @HRA = 0.30 * @basicSalary; 
end

else if(@empCity = 'Pune')
begin
set @HRA = 0.20 * @basicSalary; 
end

else if(@empCity = 'Kolkata')
begin
set @HRA = 0.20 * @basicSalary; 
end

else if(@empCity = 'Chennai')
begin
set @HRA = 0.15 * @basicSalary; 
end


  
   set @Gross = @basicSalary + @HRA + @monthlyBonus;
   set @tax = 0.08 * @Gross;

	set @NET = @Gross - @tax;
	set @CTC = @NET*12;
	return @CTC;

end



 return 0
end

select dbo.CalculateCTC(1, 'Mumbai') as CTC