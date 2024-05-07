using System.IO;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("~~~~~~Banking App~~~~~~~");

Console.WriteLine("Please Login: ");
Console.WriteLine("Enter username: ");
string userName = Console.ReadLine();

Console.WriteLine("Enter password: ");
string password = Console.ReadLine();


SqlConnection conn = new SqlConnection("server=8790060CC7795EB; database = ADONET_Practice; integrated security = true");

SqlCommand sqlCommand = new SqlCommand();
sqlCommand.Connection = conn;

sqlCommand.CommandText = "select count(*) from LoginInfo where userName = @uName and userPassword = @uPwd";
sqlCommand.Parameters.AddWithValue("@uName", userName);
sqlCommand.Parameters.AddWithValue("@uPwd", password);

conn.Open();

int count = (int)sqlCommand.ExecuteScalar();

conn.Close();





if (count == 1)
{
    Console.WriteLine("Enter a choice: ");
    Console.WriteLine("1. Open an account: ");
    Console.WriteLine("2. Withdraw balance: ");
    Console.WriteLine("3. Deposit balance");
    Console.WriteLine("4. Delete Account");
    Console.WriteLine("5. Check Balance");
    Console.WriteLine("6. Total Accounts");

    int choice = Convert.ToInt32(Console.ReadLine());


    switch (choice)
    {   //Open Account
        case 1:
            Console.WriteLine("Enter account number: ");
            int newAccno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account name: ");
            string newAccName = Console.ReadLine();
            Console.WriteLine("Enter Account Type: ");
            string newAccType = Console.ReadLine();
            Console.WriteLine("Enter Acc Balance: ");
            int newAccBalance = Convert.ToInt32(Console.ReadLine());

            sqlCommand.CommandText = "insert into CustomerInfo values(@newAccno, @newAccName, @newAccType, @newAccBalance)";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@newAccno", newAccno);
            sqlCommand.Parameters.AddWithValue("@newAccName", newAccName);
            sqlCommand.Parameters.AddWithValue("@newAccType", newAccType);
            sqlCommand.Parameters.AddWithValue("@newAccBalance", newAccBalance);

            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Account Added Successfully!");
            break;
        //Withdraw Balance
        case 2:
            Console.WriteLine("Enter account number: ");
            int withAccno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount: ");
            int withAmount = Convert.ToInt32(Console.ReadLine());

            sqlCommand.CommandText = "update CustomerInfo set accBalance = (accBalance - @withAmount) where accNo = @withAccNo";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@withAmount", withAmount);
            sqlCommand.Parameters.AddWithValue("@withAccNo", withAccno);

            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Balance withdrawn successfully");
            break;
        //Deposit Balance
        case 3:

            Console.WriteLine("Enter account number: ");
            int depAccno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount: ");
            int depAmount = Convert.ToInt32(Console.ReadLine());

            sqlCommand.CommandText = "update CustomerInfo set accBalance = (accBalance + @depAmount) where accNo = @depAccNo";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@depAmount", depAmount);
            sqlCommand.Parameters.AddWithValue("@depAccNo", depAccno);

            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Balance deposited successfully");
            break;
        //Delete Account
        case 4:
            Console.WriteLine("Enter account number: ");
            int delAccno = Convert.ToInt32(Console.ReadLine());
            sqlCommand.CommandText = "delete from CustomerInfo where accNo = @delAccno";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@delAccno", delAccno);

            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Account Deleted Successfully: "); break;
        //Check Balance
        case 5:

            break;
        case 6:
            Console.WriteLine("The total number of accounts are: ");
            sqlCommand.CommandText = " select count(*) from CustomerInfo";
            sqlCommand.Parameters.Clear();

            conn.Open();
            int total = (int)sqlCommand.ExecuteScalar();
            Console.WriteLine($"Total Employees: {total}");
            conn.Close();
            break;


        default: Console.WriteLine("Invalid Choice"); break;
    }
}
else
{
    Console.WriteLine("Invalid Credentials! ");
}