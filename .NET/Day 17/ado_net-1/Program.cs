// See https://aka.ms/new-console-template for more information
using System.Data;
using System.IO;
using System.Data.SqlClient;

#region Insert 
//SqlConnection con = new SqlConnection("server=8790060CC7795EB;database=EmployeeManagementDB; integrated security = true");

//SqlCommand cmd = new SqlCommand("insert into deptInfo values(50, 'Transport', 'Goa')", con);

//con.Open();
//cmd.ExecuteNonQuery();  //execute sql

//con.Close();

//Console.WriteLine("New Department Created!");
#endregion

#region Delete
//SqlConnection con2 = new SqlConnection("server=8790060CC7795EB; database=EmployeeManagementDB; integrated security = true");

//SqlCommand cmd_deletedept= new SqlCommand("delete from deptInfo where deptNo = 60", con2);

//con2.Open();
// cmd_deletedept.ExecuteNonQuery();

//con2.Close();
//Console.WriteLine("Dept deleted successfully");


#endregion

#region UserInput ADO.NET

Console.WriteLine("Enter a choice!");
Console.WriteLine("1. Enter a new employee");
Console.WriteLine("2. Update Employee");
Console.WriteLine("3. Delete Employee");

int choice = Convert.ToInt32(Console.ReadLine());

//new sql connection object 
SqlConnection con3 = new SqlConnection("server=8790060CC7795EB; database=EmployeeManagementDB; integrated security = true");

SqlCommand cmd = new SqlCommand();
cmd.Connection = con3;
switch (choice)
{
   //insert new dept
       case 1:
        Console.WriteLine("Enter new department number to insert:");
        int newdeptNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter new department name:");
        string newdeptName = Console.ReadLine();
        Console.WriteLine("Enter new department city:");
        string newdeptCity = Console.ReadLine();
       

        cmd.CommandText = "insert into deptInfo values(@deptNo, @deptName, @deptCity)";
        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@deptNo", newdeptNo);
        cmd.Parameters.AddWithValue("@deptName", newdeptName);
        cmd.Parameters.AddWithValue("@deptCity", newdeptCity);


        con3.Open();
         cmd.ExecuteNonQuery();
        con3.Close();
        Console.WriteLine("Added Data Successfully!");
        break;
    //update new dept   
    case 2:
        Console.WriteLine("Enter the new dept name: ");
        string newDeptName = Console.ReadLine();
        Console.WriteLine("Enter the dept no: ");
        int oldDeptNo = Convert.ToInt32(Console.ReadLine());

        cmd.CommandText = "update deptInfo set deptName = @newdeptName where deptNo = @oldDeptNo";
        cmd.Parameters.AddWithValue("@newdeptName", newDeptName);
        cmd.Parameters.AddWithValue("@oldDeptNo", oldDeptNo);
        con3.Open();
        cmd.ExecuteNonQuery();
        con3.Close();
        Console.WriteLine("Data Updated Successfully!");
        break;
    //delete existing dept
    case 3:
        Console.WriteLine("Enter dept no to delete: ");
        int deleteDeptNo = Convert.ToInt32(Console.ReadLine());
        cmd.CommandText = "delete from deptInfo where deptNo = @deletedeptNo";
        cmd.Parameters.AddWithValue("@deletedeptNo", deleteDeptNo);

        con3.Open();
        cmd.ExecuteNonQuery();
        con3.Close();

        Console.WriteLine("Deleted Data Successfully!");

        break;
    default:
        break;

            
}


#endregion UserInput ADO.NET