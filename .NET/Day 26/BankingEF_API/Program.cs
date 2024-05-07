// See https://aka.ms/new-console-template for more information
using BankingEF_API;
Console.WriteLine("Accounts Info As Follows: ");

accountsClassAPI accountsData = new accountsClassAPI();

var data = accountsData.ConsumeAccountsAPI();

foreach (var i in data)
{
    Console.WriteLine("Account ID: " + i.accNo);
    Console.WriteLine("Account Name: " + i.accName);
    Console.WriteLine("Account Type: " + i.accType);
    Console.WriteLine("Account Balance: " + i.accBalance);
    Console.WriteLine("Account Active Status: " + i.accIsActive);
    Console.WriteLine("Account Branch: " + i.accBranch);
    Console.WriteLine("--------------------------");
}
