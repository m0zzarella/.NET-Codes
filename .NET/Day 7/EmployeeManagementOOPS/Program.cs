// See https://aka.ms/new-console-template for more information
using EmployeeManagementOOPS;
    Console.WriteLine("Hello, World!");

Manager manObj1 = new Manager();
manObj1.availableLeaves = 30;

Developer devObj1 = new Developer();
devObj1.availableLeaves = 30;

Sales salesObj1 = new Sales();
salesObj1.availableLeaves = 30;


Console.WriteLine($"Leaves Applied! Your availavle leaves: {manObj1.applyLeaves(3)}");
Console.WriteLine($"Leaves Applied! Your availavle leaves: {devObj1.applyLeaves(2)}");
Console.WriteLine($"Leaves Applied! Your availavle leaves: {salesObj1.applyLeaves(3)}");
