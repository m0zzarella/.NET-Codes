// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using Microsoft.Data.SqlClient;

#region SP 1 - Select All Data

//SqlConnection conn = new SqlConnection("server = 8790060CC7795EB; database=flightDB_SP; integrated security = true; TrustServerCertificate=true");

//SqlCommand cmd = new SqlCommand("proc_SelectAllData", conn);

//cmd.CommandType = System.Data.CommandType.StoredProcedure;

////cmd.Parameters.Add(new SqlParameter()); //Parameters for stored procedures;

//conn.Open();
//SqlDataReader read = cmd.ExecuteReader();   //Execute and point towards the first line first columns
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

#region select data according to FlightNo

//SqlConnection con = new SqlConnection("server=8790060CC7795EB;database=flightDB_SP;integrated security=true;TrustServerCertificate=true");

//SqlCommand cmd = new SqlCommand("proc_FlightInfofNo", con);

//cmd.CommandType = System.Data.CommandType.StoredProcedure;
//Console.WriteLine("Please enter Flight No. to view details: ");
//var userData = Console.ReadLine();
//cmd.Parameters.AddWithValue("@fNO", userData);

//con.Open();

//SqlDataReader rd = cmd.ExecuteReader();

//if (rd.Read())
//{
//    Console.WriteLine(rd[0]);
//    Console.WriteLine(rd[1]);
//    Console.WriteLine(rd[2]);
//    Console.WriteLine(rd[3]);
//    Console.WriteLine(rd[4]);
//}
//else
//{
//    Console.WriteLine("Data Not Found");
//}

#endregion

#region 3. Print all the flight details according to the source and the destination

//SqlConnection con = new SqlConnection("server=8790060CC7795EB;database=flightDB_SP;integrated security=true;TrustServerCertificate=true");

//SqlCommand cmd = new SqlCommand("proc_FlightSourceDestination", con);

//cmd.CommandType = System.Data.CommandType.StoredProcedure;
//Console.WriteLine("Please enter Source: ");
//var SourceCity = Console.ReadLine();
//Console.WriteLine("Please enter Destination: ");
//var DestinationCity = Console.ReadLine();
//cmd.Parameters.AddWithValue("@fSource", SourceCity);
//cmd.Parameters.AddWithValue("@fDestination", DestinationCity);

//con.Open();

//SqlDataReader rd = cmd.ExecuteReader();
//int check = 0;

//while (rd.Read())
//{
//    check++;
//    Console.WriteLine(rd[0]);
//    Console.WriteLine(rd[1]);
//    Console.WriteLine(rd[2]);
//    Console.WriteLine(rd[3]);
//    Console.WriteLine(rd[4]);




//}
//if(check==0)
//{
//   Console.WriteLine("Data Not Found");
//}

#endregion

#region Update

//SqlConnection con = new SqlConnection("server=8790060CC7795EB;database=flightDB_SP;integrated security=true;TrustServerCertificate=true");

//SqlCommand cmd = new SqlCommand("proc_EditflightStatus", con);

//cmd.CommandType = System.Data.CommandType.StoredProcedure;


//Console.WriteLine("Please enter Flight Number: ");
//var flightNo = Console.ReadLine();
//Console.WriteLine("Please enter new flight status (In Progress/ Scheduled/Cancelled/Completed: ");
//var newStatus = Console.ReadLine();


//cmd.Parameters.AddWithValue("@fNo", flightNo);
//cmd.Parameters.AddWithValue("@newflightStatus", newStatus);

//con.Open();

//int check = cmd.ExecuteNonQuery();

//if(check>0)
//    Console.WriteLine("Records Updated");
//else
//    Console.WriteLine("No records to update");

//con.Close();




#endregion

#region delete flight records

//SqlConnection con = new SqlConnection("server=8790060CC7795EB;database=flightDB_SP;integrated security=true;TrustServerCertificate=true");

//SqlCommand cmd = new SqlCommand("proc_deleteFlight", con);

//cmd.CommandType = System.Data.CommandType.StoredProcedure;


//Console.WriteLine("Please enter Flight Number: ");
//var flightNo = Console.ReadLine();



//cmd.Parameters.AddWithValue("@fNo", flightNo);


//con.Open();

//int check = cmd.ExecuteNonQuery();

//if (check > 0)
//    Console.WriteLine("Records Deleted");
//else
//    Console.WriteLine("No records to update");

//con.Close();


#endregion

#region Insert

SqlConnection con = new SqlConnection("server=8790060CC7795EB;database=flightDB_SP;integrated security=true;TrustServerCertificate=true");

SqlCommand cmd = new SqlCommand("proc_InsertNewFlight", con);

cmd.CommandType = System.Data.CommandType.StoredProcedure;


Console.WriteLine("Please enter Flight Number: ");
var flightNo = Console.ReadLine();
Console.WriteLine("Please enter Flight Source City: ");
var sCity = Console.ReadLine();
Console.WriteLine("Please enter Flight Dest City: ");
var dCity = Console.ReadLine();

Console.WriteLine("Please enter new flight status (In Progress/ Scheduled/Cancelled/Completed: ");
var fStatus = Console.ReadLine();
Console.WriteLine("Please enter Flight Fare: ");
var fFare = Console.ReadLine();


cmd.Parameters.AddWithValue("@fNo", flightNo);
cmd.Parameters.AddWithValue("@fSource", sCity);
cmd.Parameters.AddWithValue("fDest", dCity);
cmd.Parameters.AddWithValue("@fStatus",fStatus);
cmd.Parameters.AddWithValue("@fFare", fFare);

con.Open();

int check = cmd.ExecuteNonQuery();

if (check > 0)
    Console.WriteLine("Records Inserted");
else
    Console.WriteLine("No records to update");

con.Close();
#endregion
