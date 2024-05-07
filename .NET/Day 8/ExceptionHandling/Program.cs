
// See https://aka.ms/new-console-template for more information
using ExceptionHandling;
Console.WriteLine("Hello, World!");

//try
//{
//    Calculate obj1 = new Calculate();

//    Console.WriteLine("Enter first number: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter second number: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine($"Result is: {obj1.DivideNumbers(num1, num2)}");
//}

//catch (Exception es)
//{
//    Console.WriteLine(es.Message);

//}
//finally        //neural block always executes whether error or not   //use to clear resources myFile.Close(); etc
//{
//    Console.WriteLine("Thank You!");
//}

try
{
    BankAccount newObj1 = new BankAccount(10000);
    int depositAmount;
    Console.WriteLine($"Account Balance: {newObj1.accBalance}");
    Console.WriteLine("Enter amount to deposit: ");
    depositAmount = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"New Account Balance: {newObj1.Deposit(depositAmount)}");
}

catch(Exception es)
{
    Console.WriteLine(es.Message);
}
finally
{
    Console.WriteLine("Thank You!");
}



