// See https://aka.ms/new-console-template for more information

//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

#region SP 1 - Select All Data

//SqlConnection conn = new SqlConnection("server = 8790060CC7795EB; database=empDB_SP; integrated security = true; TrustServerCertificate=true");

//SqlCommand cmd = new SqlCommand("proc_AllDept", conn);

//cmd.CommandType = System.Data.CommandType.StoredProcedure;

////cmd.Parameters.Add(new SqlParameter()); //Parameters for stored procedures;

//conn.Open();
//           SqlDataReader read =    cmd.ExecuteReader();   //Execute and point towards the first line first columns
//// read.Read() move to next

//while (read.Read())
//{
//    Console.WriteLine(read[0]);
//    Console.WriteLine(read[1]);
//    Console.WriteLine(read[2]);
//    Console.WriteLine("------------------");
//}

//read.Close();
//conn.Close();

#endregion

#region select data according to DeptNo

//SqlConnection con = new SqlConnection("server=8790060CC7795EB;database=empDB_SP;integrated security=true;TrustServerCertificate=true");

//SqlCommand cmd = new SqlCommand("proc_DeptInfo", con);

//cmd.CommandType = System.Data.CommandType.StoredProcedure;
//Console.WriteLine("Please enter Dept No, to view details: ");
//var userData = Console.ReadLine();
//cmd.Parameters.AddWithValue("@dNO",userData);

//con.Open();

//SqlDataReader rd = cmd.ExecuteReader();

//if(rd.Read())
//{
//    Console.WriteLine(rd[0]);
//    Console.WriteLine(rd[1]);
//    Console.WriteLine(rd[2]);
//}
//else
//{
//    Console.WriteLine("Data Not Found");
//}

#endregion


SqlConnection con = new SqlConnection("server=8790060CC7795EB;database=empDB_SP;integrated security=true;TrustServerCertificate=true");

SqlCommand cmd = new SqlCommand("proc_deptbyLocation", con);

cmd.CommandType = System.Data.CommandType.StoredProcedure;
Console.WriteLine("Please enter Dept City, to view details: ");
var userData = Console.ReadLine();
cmd.Parameters.AddWithValue("@dCity", userData);

con.Open();

SqlDataReader rd = cmd.ExecuteReader();

if (rd.Read())
{
    Console.WriteLine(rd[0]);
    Console.WriteLine(rd[1]);
    Console.WriteLine(rd[2]);
    rd.Read();
    Console.WriteLine(rd[0]);
    Console.WriteLine(rd[1]);
    Console.WriteLine(rd[2]);



}
else
{
    Console.WriteLine("Data Not Found");
}
