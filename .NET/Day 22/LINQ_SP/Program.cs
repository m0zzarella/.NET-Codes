// See https://aka.ms/new-console-template for more information
using LINQ_SP;
using Microsoft.EntityFrameworkCore;

#region SP 1 get all data

//InsuranceDbSpLinqContext insurance = new InsuranceDbSpLinqContext();

//Console.WriteLine("----Insurance LINQ-----");

//var data = insurance.PolicyDetails.FromSql($"execute proc_getAllData").ToList();

//foreach (var item in data)
//{
//    Console.WriteLine($"Policy No: {item.PolicyNo}, Policy Name: {item.PolicyName}, Policy Premium: {item.PolicyPremium} ");

//}

#endregion

#region SP 2 get by number
//InsuranceDbSpLinqContext db1 = new InsuranceDbSpLinqContext();

//Console.WriteLine("Enter Policy No: ");
//int policyNo = Convert.ToInt32(Console.ReadLine());

//var data = db1.PolicyDetails.FromSql($"execute proc_getDataByPNo {policyNo}").ToList();

//int check = 0;

//foreach(var item in data)
//{
//    check++;
//    Console.WriteLine($"Policy No: {item.PolicyNo}, Policy Name: {item.PolicyName}, Policy Premium: {item.PolicyPremium} ");

//}

#endregion

#region SP 3
//InsuranceDbSpLinqContext db1 = new InsuranceDbSpLinqContext();

//Console.WriteLine("Enter Policy Name: ");
//var policyName = Console.ReadLine();

//var data = db1.PolicyDetails.FromSql($"execute proc_getDataByPName {policyName}");

//int check = 0;

//foreach (var item in data)
//{
//    check++;
//    Console.WriteLine($"Policy No: {item.PolicyNo}, Policy Name: {item.PolicyName}, Policy Premium: {item.PolicyPremium} ");

//}
#endregion

#region SP 4
//InsuranceDbSpLinqContext db1 = new InsuranceDbSpLinqContext();

//Console.WriteLine("Enter Range 1: ");
//int range1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Range 2: ");
//int range2 = Convert.ToInt32(Console.ReadLine());


//var data = db1.PolicyDetails.FromSql($"execute proc_getRangePolicy {range1},{range2}");

//int check = 0;

//foreach (var item in data)
//{
//    check++;
//    Console.WriteLine($"Policy No: {item.PolicyNo}, Policy Name: {item.PolicyName}, Policy Premium: {item.PolicyPremium} ");

//}
#endregion

#region Insert New SP 5

//InsuranceDbSpLinqContext db1 = new InsuranceDbSpLinqContext();

//Console.WriteLine("Enter Policy No: ");
//int policyNo = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Policy Name: ");
//var policyName = Console.ReadLine();
//Console.WriteLine("Enter Policy Premium: ");
//int policyPremium = Convert.ToInt32(Console.ReadLine());


//var data = db1.PolicyDetails.FromSql($"execute proc_InsertNewPolicy {policyNo},{policyName},{policyPremium}").ToList();





#endregion

#region 6 Delete
InsuranceDbSpLinqContext db1 = new InsuranceDbSpLinqContext();

Console.WriteLine("Enter Policy No: ");
int policyNo = Convert.ToInt32(Console.ReadLine());



var data = db1.PolicyDetails.FromSql($"execute proc_deletePolicy {policyNo}").ToList();

#endregion