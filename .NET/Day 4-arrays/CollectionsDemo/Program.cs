// See https://aka.ms/new-console-template for more information
using System.IO; using System;
using System.Collections;
Console.WriteLine("Hello, World!");




#region BasicLoop
//int[] myNumbers = new int[5];

//double total = 0;

//Console.WriteLine("Enter how many numbers you want to add: ");
//int num = 0;
//num = Convert.ToInt32(Console.ReadLine());

//for ( int i = 0; i < num; i++ )
//{
//    Console.WriteLine("Enter number " + i + " : ");
//    myNumbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//for  ( int i = 0;i<myNumbers.Length;i++ )
//{
//    total += myNumbers[i];
//}

//Console.WriteLine("The addition of numbers ar:e " + total);
#endregion

#region showEvenOdd 

//int Number = 0;

//Console.WriteLine("Enter how many numbers you want to store, between 1 and 20: ");
//Number = Convert.ToInt32(Console.ReadLine());

//int[] allNumbers = new int[Number];
//int totalOfAllNumber = 0;
//int evenNumbers = 0;
//int oddNumbers = 0;
//int totalNumbers = 0;
//int negativeNumbers = 0;

//for (int i = 0; i < allNumbers.Length; i++)
//{
//    Console.WriteLine("Enter Number " + (i + 1) + ": ");
//    allNumbers[i] = Convert.ToInt32(Console.ReadLine());

//    totalOfAllNumber = totalOfAllNumber + allNumbers[i];

//    if (allNumbers[i] % 2 == 0)
//    {
//        evenNumbers++;
//    }
//    else 
//    {
//        oddNumbers++;
//    }
//    if (allNumbers[i] < 0)
//    {
//        negativeNumbers++;
//    }
//    totalNumbers++;

//}

//Console.WriteLine("Total Numbers entered : " + totalNumbers);
//Console.WriteLine("Sum of All the numbers : " + totalOfAllNumber);
//Console.WriteLine("Even Numbers : " + evenNumbers);
//Console.WriteLine("Odd Numbers : " + oddNumbers);
//Console.WriteLine("Negative Numbers: " + negativeNumbers);


#endregion

#region Task 1

//Console.WriteLine("How many guests you are expecting");

//int guests = Convert.ToInt32(Console.ReadLine());

//string[] names = new string[guests];

//int maleguests = 0, femaleguests = 0;

//for (int i = 0; i < guests; i++)
//{
//    Console.WriteLine("Enter your name :");
//    names[i] = Console.ReadLine();

//    Console.WriteLine("Enter Guest + " i + " gender: ");

//    string info = Console.ReadLine();


//    if (info == "male")
//    {
//        maleguests++;

//        names[i] = "Mr." + names[i];
//    }

//    else if (info == "female")
//    {
//        femaleguests++;

//        names[i] = "Mrs." + names[i];
//    }

//}

//Console.WriteLine("Total guests are :" + guests);
//Console.WriteLine("Number of male guests are :" + maleguests);
//Console.WriteLine("Number of female guets are :" + femaleguests);

//Console.WriteLine("Guets Lists :");

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

#endregion

#region ArrayList Collection
//Console.WriteLine("Enter values: ");
//ArrayList userValues = new ArrayList();

//bool flag = true;
// while (flag)
//{
//    string val = Console.ReadLine();
//    userValues.Add(val);
//    if (val == "") flag = false;
//}

// foreach (var item in userValues) Console.WriteLine(item);
#endregion


#region List Collection
//List<string> friends = new List<string>();


//bool flag1 = true;
//Console.WriteLine("Enter names: ");
//while (flag1)
//{ string val1 = Console.ReadLine();  
//friends.Add(val1);

//    if (val1 == "") flag1 = false;

//}

//for (int i = 0; i< friends.Count; i++)
//{ Console.WriteLine(friends[i]); }

//Console.WriteLine("Total friends: " + (friends.Count-1));
#endregion

#region Dictionary 
//Dictionary<int,string> data = new Dictionary<int,string>();

//bool flag2 = true;
//int hr = 0; int developer = 0; int dba = 0;int emp = 0;

//int i = 100;
//while (flag2)
//{
//    Console.WriteLine("Enter employee name: ");
//    string val2 = Console.ReadLine(); if (val2 == "") { flag2 = false; break; }

//    Console.WriteLine("Enter employee designation(HR/ Developer/ DBA only) :");
//    string empDesignation = "default";
//    empDesignation = Console.ReadLine();
//    emp++;
//    if (empDesignation == "HR")
//    {
//        hr++;
//    }
//    else if (empDesignation == "Developer")
//        developer++;
//    else if (empDesignation == "DBA")
//        dba++;




//    data.Add(i,val2);


   
//    i++;

//}

//foreach(var item in data)
//{ Console.WriteLine("Employee Number: " + item.Key + " ; Employee Name: " + item.Value) ;
//    Console.WriteLine("-------------------------------------------------" + Environment.NewLine);
//}
//Console.WriteLine("Total number of Employees: " + data.Count);
//Console.WriteLine($"Total HR: {hr}");
//Console.WriteLine($"Total DBA: {dba}");
//Console.WriteLine($"Total Developers: {developer}");



#endregion