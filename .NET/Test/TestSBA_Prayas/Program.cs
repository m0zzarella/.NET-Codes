// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Data;
using System.Data.SqlClient;
Console.WriteLine("SBA Test - Prayas Sanyal");

//Question 1

SqlConnection con = new SqlConnection("server=bookingInstance/sqlserver; database =  HolidayBookingDB;username =                                                            holidaysadmin;password = Holidays@1234");


//Question 2
SqlCommand cmd = new SqlCommand();
con.Open();
cmd.ExecuteNonQuery(); //this is the snippet to insert in Qs 1.2
con.Close();







