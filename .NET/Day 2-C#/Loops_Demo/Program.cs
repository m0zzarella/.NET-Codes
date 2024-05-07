// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region for loop
//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Hello World " + i);

//}
#endregion

#region Table
//Console.WriteLine("Please enter a number for the table: ");
// int tabletoPrint = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i<11; i++)
//{
//    Console.WriteLine(tabletoPrint + "*" + i + " = " + (tabletoPrint * i));

//}
#endregion

#region for loop
//int userNumbers = 20;
//int total = 0;
//int oddNumbers = 0;
//int evenNumbers = 0;
//int negativeNumbers = 0;
//int addition = 0;

//for(int i = 1; i <= userNumbers; i++)
//    {
//    Console.WriteLine("Write a number: ");
//    int value = Convert.ToInt32(Console.ReadLine());
//    addition = addition + value;

//    if (value< 0) { negativeNumbers++; }

//    if (value % 2 == 0) { evenNumbers++; } else { oddNumbers++; }

//}

//Console.WriteLine("-----Summary------");
//Console.WriteLine("Addition is " + addition);
//Console.WriteLine("Number of even numbers are: " + evenNumbers);
//Console.WriteLine("Number of odd numbers are: " + oddNumbers);
//Console.WriteLine("Negative numbers are: " + negativeNumbers);
#endregion

#region while loop
//int userN = 1;
////Console.WriteLine("Please enter a number: ");
//while (userN > 0)
//{ Console.WriteLine("Please enter a number: ");
//    userN = Convert.ToInt32(Console.ReadLine());

//    if (userN > 0) { Console.WriteLine("Good positive number!"); } else { break; }


//}
#endregion

bool continueTransaction = true;
int userChoice;

while (continueTransaction)
{
    Console.WriteLine("-------Welcome to CitiBank--------");
    Console.WriteLine("1. Login to your account!");
    Console.WriteLine("2. Create a new account");
    Console.WriteLine("3. Withdrawal");
    Console.WriteLine("4. Deposit");
    Console.WriteLine("5. Transfer ");
    Console.WriteLine("6. Pay Bill ");
    Console.WriteLine("7. Change Password");
    Console.WriteLine("8. Exit ");

    userChoice = Convert.ToInt32(Console.ReadLine());

    switch (userChoice)
    {
        case 1: Console.WriteLine("Enter your pin: ");
            Console.WriteLine("Welcome to banking!");
            break;
        case 2: Console.WriteLine("Read all the user information ");
            Console.WriteLine("New account created, thank you for the information!");
            break;
        case 3: Console.WriteLine("Enter the ammount to withdraw");
            Console.WriteLine("Amount withdrawn successfully");
            break;
        
        default:
            continueTransaction = false;
            Console.WriteLine("Sorry wrong option, please log in again!");
            break;

    }
}

