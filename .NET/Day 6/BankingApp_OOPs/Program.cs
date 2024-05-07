// See https://aka.ms/new-console-template for more information
using BankingApp_OOPs;

Console.WriteLine("Hello, World!");

//BankAccount accObj1 = new BankAccount(2023001, "Prayas", "Sanyal", 10000, true);  //NOT ALLOWED MAKES NO SENSE

//Console.WriteLine($"Account Name : {accObj1.accFirstName} {accObj1.accLastName}");
//Console.WriteLine($"Account Number: {accObj1.accNo}");
//Console.WriteLine($"Account Balance: {accObj1.accBalance}");
//Console.WriteLine($"Account Active Status: {accObj1.accIsActive}");

//mark BankAccount as ABSTRACT CLASS
//BankAccount obj1 = new BankAccount();

PF obj1 = new PF(2023001, "Prayas", "Sanyal", 10000, true);

Console.WriteLine($"PF Account Name : {obj1.accFirstName} {obj1.accLastName}");
Console.WriteLine($"PF Account Number: {obj1.accNo}");
Console.WriteLine($"PF Account Balance: {obj1.accBalance}");
Console.WriteLine($"PF Account Active Status: {obj1.accIsActive}");