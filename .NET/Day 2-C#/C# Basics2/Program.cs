// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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

#region If Condition
int firstNumber;
int secondNumber;
int subtraction;

Console.WriteLine("Enter first positive number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second positive number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber  < 0 || secondNumber < 0)
{ Console.WriteLine("Process positive numbers only! "); }

else if (secondNumber > firstNumber)
{
    Console.WriteLine("This will result in a negative result: ");
}

else
{ subtraction = firstNumber - secondNumber;
    Console.WriteLine("Subtraction is: " + subtraction);

}
#endregion

#region Switch Case
string city;
Console.WriteLine("Please enter your City");
city = Console.ReadLine();

switch (city)
{
    case "Mumbai":
        Console.WriteLine(city + " is locatted in Maharashtra ");
        Console.WriteLine("Is famous for buildings and is a financial capital of country");
        break;
    case "Kolkatta":
        Console.WriteLine(city + " is located in West Bengal");
        Console.WriteLine(city + " is famous for Bridges, food and culture");
        Console.WriteLine(city + " is known for Durga Pujo");
        break;
    case "Bangalore":
        Console.WriteLine(city + " is located in Karnataka");
        Console.WriteLine(city + " is Information technology capital of the country");
        break;
    default:
        Console.WriteLine("City Information not available");
        break;
}
#endregion

#region Task1

int Number;
Console.Write("Please enter a number: ");

Number = Convert.ToInt32(Console.ReadLine());

switch(Number)
{ case int i when i >= 1 && i <= 10:
        Console.WriteLine("Poor Number!");
        break;
  case int i when i > 10 && i <= 25:
        Console.WriteLine("Average Number!");
        break;
  case int i when i > 25 && i <=50:
        Console.WriteLine("Good Number!");
        break;
  case int i when i > 50 && i <= 75:
        Console.WriteLine("Very Good Number!");
        break;
  case int i when i > 75 && i <= 100:
        Console.WriteLine("Excellent Number!");
        break;
    case int i when i <= 1 || i > 100:
        Console.WriteLine("Number out of range!");
        break;
    default:
        Console.WriteLine("Number invalid!");
        break;

}

#endregion