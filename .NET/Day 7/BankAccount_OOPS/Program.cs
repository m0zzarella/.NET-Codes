// See https://aka.ms/new-console-template for more information
using BankAccount_OOPS;

Console.WriteLine("Hello, World!");

Savings savObj1 = new Savings();
Current currObj1 = new Current();

savObj1.accBalance = 25000;
currObj1.accBalance = 25000;

//Console.WriteLine(currObj1.Withdraw(85000));
//Console.WriteLine(savObj1.Withdraw(85000));

PF pfObj1 = new PF();
pfObj1.accBalance = 10000000;
Console.WriteLine(pfObj1.Withdraw(8100000));
