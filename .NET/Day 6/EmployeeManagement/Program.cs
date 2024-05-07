// See https://aka.ms/new-console-template for more information
using EmployeeManagement;
Console.WriteLine("Hello, World!");


Employee empObj1 = new Employee(2023001, "Rohit", "Developer", 12000, true);

//values hardcoded for now

//empObj1.empNo = 2023001;
//empObj1.empName = "Test";
//empObj1.empDesignation = "Sales";
//empObj1.empSalary = 10000;
//empObj1.empIsPermanent = true;

Console.WriteLine($"Employee Number: {empObj1.empNo}");
Console.WriteLine($"Employee Name: {empObj1.empName}");
Console.WriteLine($"Employee Designation: {empObj1.empDesignation}");
Console.WriteLine($"Employee Salary: {empObj1.empSalary}");
Console.WriteLine($"Employee Status Permanent : {empObj1.empIsPermanent}");

empObj1.changeDesignation("Sales Manager");

Console.WriteLine($"Employee New Designation: {empObj1.empDesignation}");
Console.WriteLine("Bonus: " + empObj1.CalculateBonus(30));
