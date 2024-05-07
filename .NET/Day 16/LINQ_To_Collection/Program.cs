// See https://aka.ms/new-console-template for more information

using LINQ_To_Collection;



//Console.WriteLine("Enter number of accounts to enter: ");
//int count = Convert.ToInt32(Console.ReadLine());

List<Accounts> accList = new List<Accounts>()
{
    new Accounts(){accNo=1, accName="Nikhil", accType="Savings", accBalance=10000, accBranchNo=10, accIsActive=true},
    new Accounts(){accNo=2, accName="Ravi", accType="Current", accBalance=20000, accBranchNo=20, accIsActive=true},
    new Accounts(){accNo=3, accName="Kishan", accType="Savings", accBalance=8000, accBranchNo=10, accIsActive=false},
    new Accounts(){accNo=4, accName="Pooja", accType="Savings", accBalance=12000, accBranchNo=10, accIsActive=true},
    new Accounts(){accNo=5, accName="Hema", accType="Savings", accBalance=900, accBranchNo=20, accIsActive=true},
    new Accounts(){accNo=6, accName="Mohit", accType="Savings", accBalance=18000, accBranchNo=10, accIsActive=false},
    new Accounts(){accNo=7, accName="Rakesh", accType="Current", accBalance=15800, accBranchNo=10, accIsActive=true},
    new Accounts(){accNo=8, accName="Saurabh", accType="Savings", accBalance=12900, accBranchNo=10, accIsActive=true},
    new Accounts(){accNo=9, accName="Manish", accType="Savings", accBalance=2000, accBranchNo=30, accIsActive=true},
    new Accounts(){accNo=10, accName="Mansi", accType="Savings", accBalance=60000, accBranchNo=30, accIsActive=true},
    new Accounts(){accNo=11, accName="Riddhi", accType="Savings", accBalance=120000, accBranchNo=10, accIsActive=true},
    new Accounts(){accNo=12, accName="John", accType="Current", accBalance=60000, accBranchNo=30, accIsActive=false},
    new Accounts(){accNo=13, accName="Kevin", accType="Savings", accBalance=330000, accBranchNo=20, accIsActive=true},
};

#region user input
//for (int i = 0; i< count; i++)
//    {
//    Console.WriteLine($"Enter details for account #{i + 1}:");

//    Accounts account = new Accounts();

//    Console.Write("Account Number: ");
//    account.accNo = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Account Name: ");
//    account.accName = Console.ReadLine();

//    Console.Write("Account Type: ");
//    account.accType = Console.ReadLine();

//    Console.Write("Account Balance: ");
//    account.accBalance = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Account Is Active (true/false): ");
//    account.accIsActive = Convert.ToBoolean(Console.ReadLine());

//    Console.Write("Account Branch: ");
//    account.accBranch = Convert.ToInt32(Console.ReadLine());

//    accList.Add(account);

//    Console.WriteLine("Account added successfully!\n");

//}
#endregion

#region Select * with LINQ
//select * from datasource (accList holds all the data, and thus it is a datasource - type is collection/list

var allAccounts = from a in accList
                  select a;   //sort, filter, calculate etc in betweek this 2 lines  
                              //this is equal to select * from sourceTable
                              //linq uses reverse of sql language
                              //we used a here, which is like a pointer/reference to the data, cannot use * as it an operator

foreach (var account in allAccounts)
{
    Console.WriteLine(account.accNo);
    Console.WriteLine(account.accName);
}
#endregion

#region select with where clause - filter data

var accSavings = from a in accList
                 where a.accType == "Current" && a.accBalance > 100
                 select a;

foreach (var item in accSavings)
{
    Console.WriteLine("Account No " + item.accNo);
    Console.WriteLine("Account Name " + item.accName);
    Console.WriteLine("Account Type " + item.accType);
    Console.WriteLine("-----------------------------------");
}

#endregion

#region Sort the data by accType and then by accName

var accDetails = from a in accList
                 orderby a.accType, a.accBalance
                 select a;

foreach (var accie in accDetails)
{
    Console.WriteLine(accie.accNo + "  " + accie.accType + "  " + accie.accBalance);
}



#endregion

#region Order by accBalnce desc

var acc = from a in accList
          orderby a.accBalance descending
          select a;

foreach (var item in acc)
{
    Console.WriteLine(item.accBalance + " " + item.accName + " " + item.accNo);
}

#endregion

#region like operator - we use functions here

var acc1 = from a in accList
          where a.accName.StartsWith("N")
          select a;

var acc2 = from a in accList
          where a.accName.EndsWith("l")
          select a;

foreach (var item in acc1)
{
    Console.WriteLine(item.accName);
}

#endregion

#region aggregations

//LINQ

var totalAccounts = (from a in accList
                     select a.accNo).Count();

Console.WriteLine("Total Accounts " + totalAccounts);

var totalBalance = (from a in accList
                    select a.accBalance).Sum();

Console.WriteLine("Total Balance " + totalBalance);

var totalSavingsAccount = (from a in accList
                           where a.accType == "Savings"
                           select a.accNo).Count();

Console.WriteLine("Total Savings account " + totalSavingsAccount);


////LAMBDA expression
//var totalAccBalance = accList.Sum(a => a.accBalance);
//var totalSavingsBalance = accList.Where(a => a.accType == "Savings").Sum(a => a.accBalance);


#endregion
