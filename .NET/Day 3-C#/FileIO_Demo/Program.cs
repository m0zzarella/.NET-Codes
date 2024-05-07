// See https://aka.ms/new-console-template for more information
using System.IO;
#region Demo 1
//Console.WriteLine("FileIO Demo");

//FileStream myFile= new FileStream("myintro.txt", FileMode.Create, FileAccess.Write); //create a new file with write permission 

////pen to write into file

//StreamWriter myPen = new StreamWriter(myFile);
//myPen.WriteLine("Welcome to the file!");
//myPen.WriteLine("My Name is Prayas Sanyal");
//myPen.WriteLine("I live in Kolkata!");
//myPen.WriteLine("Thank you!");

//myPen.Close();
//myFile.Close();

//Console.WriteLine("Details written inside the file!");
#endregion

#region WriteToFile
//string guestName = "";
//Console.WriteLine("Please enter your name: ");
//guestName = Console.ReadLine();


//FileStream userFile = new FileStream(guestName + ".txt", FileMode.Create, FileAccess.Write);
//StreamWriter userWriter = new StreamWriter(userFile);

//string info;
//Console.WriteLine("Please Enter Your Full Name: ");
//info = Console.ReadLine();

//userWriter.WriteLine("Name: " + info);

//Console.WriteLine("Please enter where you live: ");
//info = Console.ReadLine();

//userWriter.WriteLine("City: " + info);

//Console.WriteLine("Please enter your favourite movie: ");
//info = Console.ReadLine();

//userWriter.WriteLine("Favourite Movie: " + info);

//Console.WriteLine("Please enter your favourite dish: ");
//info = Console.ReadLine();

//userWriter.WriteLine("Favourite Dish: " + info);

//Console.WriteLine("Please enter your favourites sports: ");
//info = Console.ReadLine();

//userWriter.WriteLine("Favourite Sports: " + info);


//Console.WriteLine("Please tell us more about you: ");
//info = Console.ReadLine();

//userWriter.WriteLine("Description about user: " + info);

//userWriter.Close();
//userFile.Close();

//Console.WriteLine("User details saved succesfully!");
#endregion

#region ReadFromFile

//FileStream myFile = new FileStream("Prayas.txt",FileMode.Open,FileAccess.Read);
//StreamReader readMyFile = new StreamReader(myFile);

//Console.WriteLine(readMyFile.ReadToEnd());

//readMyFile.Close();
//myFile.Close();
#endregion

#region ReadFromFile

//string name;
//Console.WriteLine("Please enter the file you want to open");
//name = Console.ReadLine();

//if (File.Exists(name + ".txt"))
//{
//    FileStream myFile = new FileStream(name + ".txt", FileMode.Open, FileAccess.Read);
//    StreamReader readMyFile = new StreamReader(myFile);

//    Console.WriteLine(readMyFile.ReadToEnd());

//    readMyFile.Close();
//    myFile.Close();
//}

//else
//{
//    Console.WriteLine("Sorry User Details Not Found");
//}

#endregion

#region read from file txt
//Console.WriteLine("Welcome to EMS!");
//Console.WriteLine("Please enter your login credentials: " + Environment.NewLine + "Press enter to continue");

//Console.ReadLine();

//string username;
//string password;

//Console.WriteLine("Please enter your username: ");
//username = Console.ReadLine();

//Console.WriteLine("Please enter your password: ");
//password = Console.ReadLine();

//if(username == null || password == null)
//{
//    Console.WriteLine("Please enter  valid credentials:");
//}

#endregion

string fileName = "autonumber.txt";

  if (File.Exists(fileName))
{   //read number from file and then increment it and store it back to the file

    FileStream read_numberFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
    StreamReader readNumber = new StreamReader(read_numberFile);
    int value = Convert.ToInt32(readNumber.ReadLine());
    Console.WriteLine(value);       
    Console.WriteLine("Number from file: " + value);

    readNumber.Close();
    read_numberFile.Close();

    value++; //storing the number back to the file

    FileStream write_numberFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);  
    StreamWriter writeNumber = new StreamWriter(write_numberFile);
    writeNumber.WriteLine(value);
    writeNumber.Close();
    write_numberFile.Close();                                                             
   Console.WriteLine("Number Saved to File: " + value);
}
  else
{
    //let system create a new file, add a default number to it and save the file, we will read it next time
    FileStream writeDefaulNumberFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
    StreamWriter writeDEfaultNumber = new StreamWriter(writeDefaulNumberFile);
    writeDEfaultNumber.Write(1);
    writeDEfaultNumber.Close();
    writeDefaulNumberFile.Close();
    Console.WriteLine("New File created and Number is set to 1");
}