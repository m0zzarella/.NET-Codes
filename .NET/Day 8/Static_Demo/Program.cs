// See https://aka.ms/new-console-template for more information
using Static_Demo;

Console.WriteLine("Hello, World!");


#region hardcode
//Console.WriteLine("Enter Name of User 1: ");
//string empName1 = Console.ReadLine();

//Console.WriteLine("Enter Designation of User 1: ");
//string empDesg1 = Console.ReadLine();



//Console.WriteLine("Enter Name of User 2: ");
//string empName2 = Console.ReadLine();

//Console.WriteLine("Enter Designation of User 2: ");
//string empDesg2 = Console.ReadLine(); ;



//Console.WriteLine("Enter Name of User 3: ");
//string empName3 = Console.ReadLine();

//Console.WriteLine("Enter Designation of User 3: ");
//string empDesg3 = Console.ReadLine(); ;




//EmployeeInfo obj1 = new EmployeeInfo(empName1, empDesg1);
//EmployeeInfo obj2 = new EmployeeInfo(empName2, empDesg2);
//EmployeeInfo obj3 = new EmployeeInfo(empName3, empDesg3);

//Console.WriteLine("Details of User 1: ");
//Console.WriteLine($"Emp Id: {obj1.empNo}; Emp Name: {obj1.empName}; Emp Desg: {obj1.empDesg}");

//Console.WriteLine("Details of User 2: ");
//Console.WriteLine($"Emp Id: {obj2.empNo}; Emp Name: {obj2.empName}; Emp Desg: {obj2.empDesg}");

//Console.WriteLine("Details of User 3: ");
//Console.WriteLine($"Emp Id: {obj3.empNo}; Emp Name: {obj3.empName}; Emp Desg: {obj3.empDesg}");

#endregion

List<EmployeeInfo> employees = new List<EmployeeInfo>();

bool moreObjects = true;
int userI = 1;

while (moreObjects)
{
    string eDesig = "";
    Console.WriteLine($"Enter the name of User {userI}: ");
    string eName = Console.ReadLine();

    Console.WriteLine($"Enter the designation of User {userI}: Press 1 for Manager, 2 for HR, 3 for Developer: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        eDesig = "Manager";
        Manager empObj = new Manager(eName, eDesig);
        employees.Add(empObj);
        Console.WriteLine($"Employee created, the Employee Number is: {empObj.empNo}");
    }
    else if (choice == 2)
    {
        eDesig = "HR";
        HR empObj = new HR(eName, eDesig);
        employees.Add(empObj);
        Console.WriteLine($"Employee created, the Employee Number is: {empObj.empNo}");
    }
    else if (choice == 3)
    {
        eDesig = "Developer";
        Developer empObj = new Developer(eName, eDesig);
        employees.Add(empObj);
        Console.WriteLine($"Employee created, the Employee Number is: {empObj.empNo}");
    }


    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("Do you want to add more employees?"); Console.WriteLine("1. Yes   2. No");

    int more = Convert.ToInt32(Console.ReadLine());
    if (more == 2)
    {
        Console.WriteLine("Thank You!"); moreObjects = false;
    }
    userI++;

}