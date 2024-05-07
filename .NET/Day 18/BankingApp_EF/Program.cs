//// See https://aka.ms/new-console-template for more information
//using BankingApp_EF;
using BankingApp_EF;
using Microsoft.EntityFrameworkCore;


Console.WriteLine("Hello, World!");

BankingDbEfContext db = new BankingDbEfContext();//source for LINQ queries
var emp = from e in db.BranchInfos select e; //(you can use filter, order by, group by, in between this 2 lines)

//	foreach (var item in emp)
//{
//    Console.WriteLine(item.BranchNo);
//    Console.WriteLine(item.BranchName);
//    Console.WriteLine(item.BranchLocation);
//}


//all accounts
//var allAcc = from a in db.AccountsInfos select a;

//display selected accounts

var allAcc = from a in db.AccountsInfos
             select new
             {
                 Account_Number = a.AccNo,
                 Account_Name = a.AccName,
                 Account_Branch = a.AccBranch,
                 Account_Type = a.AccType,
                 Account_Balance = a.AccBalance
             };

//	foreach (var item in allAcc)
//{
//    Console.WriteLine(item.Account_Number);
//    Console.WriteLine(item.Account_Name);
//    Console.WriteLine(item.Account_Branch);
//    Console.WriteLine(item.Account_Type);
//    Console.WriteLine(item.Account_Balance);
//    Console.WriteLine(Environment.NewLine+ "-----------------------" + Environment.NewLine);
//}

//	var acc = from a in db.AccountsInfos
//		  select a;

//	var branches = from b in db.BranchInfos
//			select b;

//	var accSavings = from a in db.AccountsInfos
//			 where a.AccType == "Savings"
//			 select a;
////display all the accounts from accounts table which are inactive
//	var accPermenat = from a in db.AccountsInfos
//			   where a.AccIsActive == false
//		          select a;

////display all the accounts from accounts table which are of type PF and inactive
//	var accPF_In = from a in db.AccountsInfos
//			where a.AccType == "Savings" && a.AccIsActive == false
//			select a; 

// //display all the accounts from accounts table, display the data in order of Name (A-Z)
//	var accName = from a in db.AccountsInfos
//		      orderby a.AccName
//		      select a;



//	var accountFiler = from a in db.AccountsInfos
//			  where a.AccBalance > 25000
//			 orderby a.AccBalance descending
//			select a;

////8.display total of all the account balance
//	var total = (from a in db.AccountsInfos 
//			select a.AccBalance).Sum();


////var total1 = from a in db.AccountsInfos
////			 select new { total_balance = a.Sum(a => a.accBalance) };  //old syntax LAMBDA express

////9. display total Inactive accounts
//	var inactive = (from a in db.AccountsInfos			
//			where a.AccIsActive == false
//			select a.AccIsActive).Count();

////10.we want to display accName as Name,  accBalance as AvailableBalance 10% of accBalance as Intrest from account table

//	var acc1 = from a in db.AccountsInfos
//			select new
//                   {
//                       Name = a.AccName,
//                       AvailableBalance = a.AccBalance,
//                       Interest = a.AccBalance * 0.1
//            };

var query = from account in db.AccountsInfos
            join branch in db.BranchInfos on account.AccBranch equals branch.BranchNo
            select new
            {
                account.AccNo,
                account.AccName,
                account.AccType,
                account.AccBalance,
                account.AccIsActive,
                BranchName = branch.BranchName,
                BranchLocation = branch.BranchLocation
            };



//Insert new Accounts
//AccountsInfo newAcc = new AccountsInfo()
//{
//    AccNo = 12,
//    AccName = "Mohsin",
//    AccType = "Savings",
//    AccBalance = 5000,
//    AccBranch = 5,
//    AccIsActive = true
//};

//db.AccountsInfos.Add(newAcc);

//push the changes by db.SaveChanges();

db.SaveChanges();

var accToDelete = from a in db.AccountsInfos
                  where a.AccNo == 12
                  select a;
foreach(var item in accToDelete)
{ 
db.AccountsInfos.Remove(item);
}
db.SaveChanges();

//UPDate one Account


var accToUpdate = (from b in db.AccountsInfos where b.AccNo == 1
                  select b ).Single();

accToUpdate.AccName = "Robin";
db.SaveChanges();

foreach (var item in query)
{
    Console.WriteLine($"Account No: {item.AccNo}, Account Name: {item.AccName}, " +
                      $"Account Type: {item.AccType}, Account Balance: {item.AccBalance}, " +
                      $"Account Is Active: {item.AccIsActive}, Branch Name: {item.BranchName}, " +
                      $"Branch Location: {item.BranchLocation}" + Environment.NewLine);
}






