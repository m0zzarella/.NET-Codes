using BankingAPP_exception;
using System.Text;

Console.WriteLine("!! ~~~~~~~ Welcome to Banking ~~~~~~~~~ !!");

bool continueOperation = true;

void GetDetails(int accNo, string accName, double accBalance)
{
    Console.WriteLine("Enter Account Number");
    int accNo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Account Name");
    string accName = Console.ReadLine();
    Console.WriteLine("Enter Account Balance");
    double accBal = Convert.ToDouble(Console.ReadLine());

}
double balance;
while (continueOperation)
{   
    Console.WriteLine("Please Enter a choice ");
    Console.WriteLine("1. Create new Account");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("1. Savings");
            Console.WriteLine("2. Current");
            int typeOfAccount = Convert.ToInt32(Console.ReadLine());
            switch (typeOfAccount)
            {
                case 1:
                

                    try
                    {
                        Savings savObj = new Savings(accNo, accName, accBal);
                    }
                    catch(Exception es)
                    {
                        Console.WriteLine(es.Message);
                    }
                    break;
                 case 2:
                    Console.WriteLine("Enter Account Number");
                    int accNo2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Account Name");
                    string accName2 = Console.ReadLine();
                    Console.WriteLine("Enter Account Balance");
                    double accBal2 = Convert.ToDouble(Console.ReadLine());

                    try
                    {
                        Current curObj = new Current(accNo2, accName2, accBal2);
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine(es.Message);
                    }
                    break;
                default:
                    break;
            }
            break;
        case 2:
            Console.WriteLine("Enter Amount to Deposit");
            int d_amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Savings");
            Console.WriteLine("2. Current");
            int typeOfAccount2 = Convert.ToInt32(Console.ReadLine());
            switch(typeOfAccount2)
            {
                case 1:
                    Console.WriteLine("Enter Account Number");
                    int accNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Account Name");
                    string accName = Console.ReadLine();
                    Console.WriteLine("Enter Account Balance");
                    double accBal = Convert.ToDouble(Console.ReadLine());

                    try
                    {
                        Savings savObj = new Savings(accNo, accName, accBal);
                        try
                        {
                         balance =  savObj.Deposit(d_amount);
                            Console.WriteLine("New Balance " + balance);
                        }
                        catch(Exception es)
                        {
                            Console.WriteLine(es.Message);
                        }
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine(es.Message);
                    }
                    break;
                case 2:              
                    Console.WriteLine("Enter Account Number");
                    int accNo2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Account Name");
                    string accName2 = Console.ReadLine();
                    Console.WriteLine("Enter Account Balance");
                    double accBal2 = Convert.ToDouble(Console.ReadLine());

                    try
                    {
                        Savings savObj = new Savings(accNo2, accName2, accBal2);
                        try
                        {
                            balance = savObj.Withdraw(d_amount);
                            Console.WriteLine("New Balance " + balance);
                        }
                        catch (Exception es)
                        {
                            Console.WriteLine(es.Message);
                        }
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine(es.Message);
                    }
                    break;

            }
            break;
           
        default:
            continueOperation = false;
            break;

          
    }
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
    Console.Clear();


}


