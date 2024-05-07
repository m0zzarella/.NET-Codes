// See https://aka.ms/new-console-template for more information

Console.WriteLine("-----Welcome to Employee Management System!-----");
Console.WriteLine("Press Enter to Login: ");
Console.ReadLine();
Console.WriteLine("Press Which Mode: " + Environment.NewLine + "1. Employee" + Environment.NewLine + "2. Admin");

int userChoice = 0;
userChoice = Convert.ToInt32(Console.ReadLine());

switch(userChoice)
{
    case 1: Console.WriteLine("Welcome Employee!");
        Console.WriteLine("Please enter your following details: " + Environment.NewLine + "1. Your Name: ");
        string userName = "";
        userName = Console.ReadLine();
        bool continueUser = true;
        
        Console.WriteLine("2. Your Password: ");
        string password = Console.ReadLine();
       
        FileStream employeeCredFile = new FileStream(@"C:\EmployeeCred.txt", FileMode.Open, FileAccess.Read);
        StreamReader read = new StreamReader(employeeCredFile);


        string employeefileUsername = read.ReadLine();
        string employeefilePassword = read.ReadLine();

        
       
  
        if (userName == employeefileUsername && password == employeefilePassword)
        {
          

            {
                Console.WriteLine("Welcome, " + userName + "! Login Succesful." + Environment.NewLine + " Please Enter Your Choice: ");
                while (continueUser)
                {
                    Console.WriteLine("1. Check Employee Details: " + Environment.NewLine + "2. Apply Leave " + Environment.NewLine + "3. Raise a Request to Manager:  " + Environment.NewLine + "4. Submit Bill " + Environment.NewLine + "5. Fill Daily Worsksheet " + Environment.NewLine + "6. Exit");
                    int user_choice;
                    user_choice = Convert.ToInt32(Console.ReadLine());

                    switch (user_choice)
                    {
                        case 1: continueUser = true; Console.WriteLine("Welcome to Option 1. Check Employee Details; Press Enter to Continue: "); Console.ReadLine(); break;
                        case 2: Console.WriteLine("Welcome to Option 2. Apply Leave, Press Enter to Continue: "); Console.ReadLine(); break;
                        case 3: Console.WriteLine("Welcome to Option 3. Raise a Request to Manager; Press Enter to Continue: "); Console.ReadLine(); break;
                        case 4: Console.WriteLine("Welcome to Option 4. Submit Bill; Press Enter to Continue: "); Console.ReadLine(); break;
                        case 5: Console.WriteLine("Welcome to Option 5. Fill Daily Worksheet; Press Enter to Continue: "); Console.ReadLine(); break;
                        case 6: Console.WriteLine("Exiting the application."); continueUser = false; break;
                        default: Console.WriteLine("Invalid option!"); continueUser = false; break;

                    }
                }
            } 
        }
        else { Console.WriteLine("Invalid Credentials!"); }  
        read.Close();
        employeeCredFile.Close();
        break;

    case 2: Console.WriteLine("Welcome Admin!");
        Console.WriteLine("Please enter your details admin: " + Environment.NewLine + "1. Your Name: ");
        string adminName = "";
        adminName = Console.ReadLine();
        bool continueAdmin = true;
        Console.WriteLine("2. Your Password: ");
        string adminpassword = Console.ReadLine();

        FileStream adminCredFile = new FileStream(@"C:\AdminCred.txt", FileMode.Open, FileAccess.Read);
        StreamReader admin_read = new StreamReader(adminCredFile);


        string adminfileUsername = admin_read.ReadLine();
        string adminfilePassword = admin_read.ReadLine();



        if (adminName == adminfileUsername && adminpassword == adminfilePassword)
        {
            Console.WriteLine("Welcome, " + adminName + ", login succesful. Please enter the details");
            while (continueAdmin)
            {
                Console.WriteLine("1. Add New Employee: " + Environment.NewLine + "2. View Employee Details " + Environment.NewLine + "3. Delete Employee:  " + Environment.NewLine + "4. Approve Leaves " + Environment.NewLine + "5. Approve Voucher " + Environment.NewLine + "6. Announcement " + Environment.NewLine + "7. Exit");
            int adm_choice;
            adm_choice = Convert.ToInt32(Console.ReadLine());
            
                switch (adm_choice)
                {
                    case 1: Console.WriteLine("Welcome to Option 1. Add New Employee: "+ Environment.NewLine + "Press Enter to Continue:"); Console.ReadLine();
                        Console.WriteLine("Enter employee name to store the file: ");
                        string empName = Console.ReadLine();

                        FileStream empFile = new FileStream(empName + ".txt", FileMode.Create,FileAccess.Write);
                        StreamWriter empWriter = new StreamWriter(empFile);

                        string empinfo;

                        Console.WriteLine("Tell the Employee First Name: ");
                        empinfo = Console.ReadLine();
                        empWriter.WriteLine("EmpName: " + empinfo);



                        Console.WriteLine("Tell the Employee Last Name: ");
                        empinfo = Console.ReadLine();
                        empWriter.WriteLine("EmpLastName: " + empinfo);


                        Console.WriteLine("Tell the Employee City: ");
                        empinfo = Console.ReadLine();
                        empWriter.WriteLine("EmpCity: " + empinfo);



                        Console.WriteLine("Tell the Employee Designation: ");
                        empinfo = Console.ReadLine();
                        empWriter.WriteLine("EmpDesig: " + empinfo);

                        Console.WriteLine("Tell the Employee Salary: ");
                        empinfo = Console.ReadLine();
                        empWriter.WriteLine("EmpSalary: " + empinfo);



                        Console.WriteLine("Tell the Employee Available Leaves: ");
                        empinfo = Console.ReadLine();
                        empWriter.WriteLine("EmpLeaves: " + empinfo);

                        empWriter.Close();
                        empFile.Close();

                        Console.WriteLine("Thank you file for " + empName + " is stored succesfully!" + Environment.NewLine);

                        break;
                    case 2: Console.WriteLine("Welcome to Option 2, press enter to continue"); Console.ReadLine(); break;
                    case 3: Console.WriteLine("Welcome to Option 3, press enter to continue"); Console.ReadLine(); break;
                    case 4: Console.WriteLine("Welcome to Option 4, press enter to continue"); Console.ReadLine(); break;
                    case 5: Console.WriteLine("Welcome to Option 5, press enter to continue"); Console.ReadLine(); break;
                    case 6: Console.WriteLine("Welcome to Option 6, press enter to continue"); Console.ReadLine(); break;
                    case 7: Console.WriteLine("Exiting the application"); continueAdmin = false; break;
                    default: Console.WriteLine("Invalid option!"); continueAdmin = false; break;

                }
                
            }
        
        }
        else { Console.WriteLine("Invalid Credentials!"); }
        admin_read.Close();
        adminCredFile.Close();
        break;

    default: Console.WriteLine("Invalid input, Sorry!"); break;

}
