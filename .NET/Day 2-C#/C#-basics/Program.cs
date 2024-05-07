// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region FirstExample
////data types
////primitve datatype string, int , double, bool  , provided by dot net core/framework

//// custom data types / user defined datatypes   , created with help of class
////ctrl + K + C = comment a line, ctrl + K + U = uncomment
//bool isPermanent = false;
//string myName = "Prayas Sanyal";

//string myCity = "Kolkata";
//int myVehicles = 0;

//Console.WriteLine("My Name is " +  myName);
//Console.WriteLine("My City is " + myCity);

//Console.WriteLine("Am I a permanent employee?: " + isPermanent);
//Console.WriteLine("I have " + myVehicles + " vehicles");
#endregion

#region ValuesFromUser
//string guestName = "";
//int age = 0;
//string guestCity = "";

//Console.WriteLine("Please tell us your name: ");
//guestName = Console.ReadLine();

//Console.WriteLine("What is your age? ");
//age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("What city are you from? ");
//guestCity = Console.ReadLine();

//Console.WriteLine("Hello " + guestName + ", your age is " + age + ", and " + guestCity + " is wonderful! ");
#endregion

#region BasicCalc

#region Variables
//double firstNumber;
//double secondNumber;
//double add;
//double sub;
//double mult;
//double div;
#endregion

#region EnterValues
//Console.WriteLine("Enter the first number: ");
//firstNumber = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter the second number: ");
//secondNumber = Convert.ToDouble(Console.ReadLine());
#endregion

#region PrefromCalc
//add = firstNumber + secondNumber;
//sub = secondNumber - firstNumber;
//mult = firstNumber * secondNumber;
//div = secondNumber / secondNumber;
#endregion

#region DiplayCalcValues
//Console.WriteLine("Addition of numbers are: " + add);
//Console.WriteLine("Subtraction of numbers are: " + sub);
//Console.WriteLine("Multiplication of numbers are: " + mult);
//Console.WriteLine("Division of numbers are: " + div);
#endregion

#endregion

int firstNumber;
int secondNumber;
int subtraction;

Console.WriteLine("Enter first positive number: ");
firstNumber = Convert.To