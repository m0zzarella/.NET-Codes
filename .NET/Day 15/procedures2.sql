create database learning_proc2

use learning_proc2

create table AccountsInfo
( accNo int primary key,
  accName varchar(20),
  accType varchar(20),
  accBalance bigint
  )

insert into AccountsInfo values (1, 'Nikhil', 'Savings', 10000),
(2, 'Jake', 'Savings', 11000),
(3, 'Jane', 'Currents', 12300),
(4, 'Elizabeth', 'Savings', 20000),
(5, 'Mohit', 'Savings', 15000),
(6, 'Mohan', 'Currents', 20000),
(7, 'Rohan', 'Savings', 15000),
(8, 'Mahesh', 'Currents', 16000),
(9, 'Suresh', 'Savings', 10400),
(10, 'Ramesh', 'Currents', 12000);






--user should be able to withdraw, deposit, transfer, bill pay,checkBalance - we can create a

create procedure proc_Transact(@accNo int, @amt int,@action varchar(10),
							   @billPayCustID bigint = 0, @transferAccNo int = 0)
as
begin
	if(@action = 'Withdraw')
		begin
			update AccountsInfo set accBalance = accBalance - @amt where accNo = @accNo
		end
	else if(@action = 'Deposit')
		begin
			update AccountsInfo set accBalance = accBalance + @amt where accNo = @accNo
		end
	else if(@action = 'CheckBalance')
		begin
			select AccountsInfo.accBalance from AccountsInfo where accNo = @accNo
		end
	else if(@action = 'Transfer')
		begin
			update AccountsInfo set accBalance = accBalance - @amt where accNo = @accNo
			update AccountsInfo set accBalance = accBalance + @amt where accNo = @transferAccNo
		end
	else if(@action = 'BillPay')
		begin
			update AccountsInfo set accBalance = accBalance - @amt where accNo = @accNo
		end
	end
						       


select * from AccountsInfo

exec proc_Transact 1, 2000,'Withdraw'





	--procedure will add a new account and return the new accno back to user

	create procedure proc_newAccount(@accNo int out,
							         @accName varchar(20),
									 @accType varchar(20),
									 @accBalance bigint)
	as
	begin
		declare @newAccNo int;
		set @newAccNo = (select max(accNo) + 1 from AccountsInfo)

		set @accNo = @newAccNo
		insert into AccountsInfo values(@accNo, @accName,@accType,@accBalance)
	--if i say print @accNo - it will print it on the server but we want to send the value on user screen 

	end

	-------------------
	declare @acNo int ;
	exec proc_newAccount @acNo out, 'John','Savings',8000
	print @acNo
	

	--print is understood by SSMS only 





	create table transactionInfo
	(
		trNo int primary key,
		fromAccNo int,
		ToAccNo int,
		Amt int,
		datetime date
	)




	create procedure proc_transferFunds(@fromAccNo int,  --reduce the balance of this account
										@ToAccNo int, --increase the balance of this account
										@Amt int, -- this is amount 
										@trsactionNo int out) -- get transaction no from transaction table
	as
	begin
			update AccountsInfo set accBalance = accBalance - @Amt where accNo = @fromAccNo
			update AccountsInfo set accBalance = accBalance + @Amt where accNo = @ToAccNo

			--also store the history in transaction info for future reference
			--let us take the transaction no first and insert into that table
			declare @newTrNo int
			set @newTrNo = (select isnull(max(trNo),500) + 1 from transactionInfo)
			insert into transactionInfo values(@newTrNo,@fromAccNo,@ToAccNo,@Amt,GETDATE())
			set @trsactionNo = @newTrNo
	end

	declare @captureNewTrNo int
	exec proc_transferFunds 1,2,7000,@captureNewTrNo out
	print @captureNewTrNo
--this is execution environment language
--console.writeLine(@captureNewTrNo) -- consoleapp
--alert(@captureNewTrNo) -- javascript
--response.writeLine(@captureNewTrNo) --webapp
print concat('Transfer Successful : Transaction No is, ',@captureNewTrNo)
select * from transactionInfo


create procedure proc_formatPhoneNo(@phNo varchar(20) out)
as
begin
	set @phNo = CONCAT('(',SUBSTRING(@phno,1,3),'-',SUBSTRING(@phno,4,8),')')
end

declare @phoneNo varchar(20) = '0227868693563'
exec proc_formatPhoneNo @phoneNo out
print @phoneNo


create table empinfo
	(
		empno int primary key,
		empName varchar(20), 
		empDesigation varchar(20), 
		empSalary int,
		empIsActive bit
	)

	create procedure proc_newEmp(@new_empNo int out,
				     @new_email varchar(30),
				     @empName varchar(20),
				     @empDesignation varchar(20),
				     @empSalary int)
	as
	begin
       set @new_empNo = (select isnull(max(empno),0) + 1 from empInfo)
		set @new_email = lower(concat(@empName,'.',substring(@empDesignation,1,2),'@myorg.in')
	
		insert into empinfo values(@new_empNo,@empname,@empDesignation,@empSalary,1)
	end
				   
	declare @eNo int
	declare @enm varchar(30)
	exec proc_newEmp @eNo out,@enm out,'Nikhil','Trainer',4000
	print concat('Employee Added, new EmpNo is : ',@eNo,' Email address is ',@enm)





















