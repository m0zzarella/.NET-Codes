// See https://aka.ms/new-console-template for more information
Console.WriteLine("~~~~~~~~Welcome to Banking App!~~~~~~~~");
Console.WriteLine("Please Press Enter to Continue - "); Console.ReadLine();

int  userChoice = 0;
bool continueChoice = true;
int accNo = 0001;
int sav = 0;
int curr = 0;
int accounts = 0;
Dictionary<int, string> accountList = new Dictionary<int, string>();
while (continueChoice)
{
    Console.WriteLine("Choose the option to proceed: ");

Console.WriteLine("1. Create New Account" + Environment.NewLine + "2. View Account Details" + Environment.NewLine + "3. View Summary" + Environment.NewLine + "4. Exit");

userChoice = Convert.ToInt32(Console.ReadLine());





    switch (userChoice)
    { 
        case 1:
            string accName= "", accType = "", accBranchCity = "", accBalance = "";
            
            Console.WriteLine("Please Enter Your Name: ");
            accName = Console.ReadLine();

            Console.WriteLine("Please Enter Account Type (Press S for Savings, C for Current): ");
            accType = Console.ReadLine();
            if (accType == "S") { accType = "Savings"; sav++; } else if (accType == "C") { accType = "Current"; curr++; }

            Console.WriteLine("Please Enter Your Branch City: ");
            accBranchCity = Console.ReadLine();

            Console.WriteLine("Please Enter Your Balance: ");
            accBalance = Console.ReadLine();

            //string totalinfo = $"Account Name: {accName}; Account Type: {accType}; Account Branch City: {accBranchCity}; Account Balance: {accBalance}";

            accountList.Add(accNo, $"Account Name: {accName}; Account Type: {accType}; Account Branch City: {accBranchCity}; Account Balance: {accBalance}");
            Console.WriteLine("Your Account Number is: " + accNo);
            accNo++;
            accounts++;

            break;
        case 2:
            Console.WriteLine("View Account Details: ");
            Console.WriteLine("Enter Account Number: ");
            int userCheck = Convert.ToInt32(Console.ReadLine());

            foreach (var item in accountList)
            {
                Console.WriteLine(item.Key);
                if (item.Key == userCheck)

                { Console.WriteLine("Account Number: " + item.Key + Environment.NewLine + "Details: " + item.Value); }
                else { Console.WriteLine("User not found"); }
            }

            break;
        case 3:
            Console.WriteLine("Summary: ");
            Console.WriteLine("Total Accounts: " + accounts);
            Console.WriteLine("Total Savings Accounts: " + sav);
            Console.WriteLine("Total Current Accounts: " + curr);
            break;
        case 4: continueChoice = false;
            Console.WriteLine("Exiting the Application. Visit Again!");
            break;
        default:
            continueChoice = false;
            Console.WriteLine("Invalid Choice. Try Again: ");
            break;

    }
}
