using TestSBAQs3;
Console.WriteLine("SBA Qs 3 Part 1. Prayas" + Environment.NewLine);


List<FlightDetails> flightList = new List<FlightDetails>()
{
    new FlightDetails(){flightNo=1, flightName="Indigo", flightSource="Kolkata", flightDestination="Paris", flightFare=5000},
    new FlightDetails(){flightNo=2, flightName="SpiceJet", flightSource="Mumbai", flightDestination="Delhi", flightFare=10000},
    new FlightDetails(){flightNo=3, flightName="Vistara", flightSource="Pune", flightDestination="Delhi", flightFare=5500},
    new FlightDetails(){flightNo=4, flightName="Etihad", flightSource="Goa", flightDestination="Hyderabad", flightFare=7000},
    new FlightDetails(){flightNo=5, flightName="Qatar Airways", flightSource="Srinagar", flightDestination="Delhi", flightFare=5200},
    new FlightDetails(){flightNo=6, flightName="Jet Blue", flightSource="Siliguri", flightDestination="Leh", flightFare=5300},
    new FlightDetails(){flightNo=7, flightName="Jet Airways", flightSource="Kolkata", flightDestination="Paris", flightFare=8000},
    new FlightDetails(){flightNo=8, flightName="Alaska Airlines", flightSource="Chennai", flightDestination="Bangalore", flightFare=9000},
    new FlightDetails(){flightNo=9, flightName="America Airlines", flightSource="New York", flightDestination="Delhi", flightFare=9200},
    new FlightDetails(){flightNo=10, flightName="Indigo", flightSource="Kolkata", flightDestination="Doha", flightFare=15000}
 };

var flightQs1 = from a in flightList
                 where a.flightSource == "Kolkata" && a.flightDestination == "Paris"
                 select a;


foreach (var item in flightQs1)
{
    Console.WriteLine("Flight No: " + item.flightNo);
    Console.WriteLine("Flight Name: " + item.flightName);
    Console.WriteLine("Flight Source: " + item.flightSource);
    Console.WriteLine("Flight Destination: " + item.flightDestination);
    Console.WriteLine("Flight Fare: " + item.flightFare);

    Console.WriteLine(Environment.NewLine + "-----------------------------------" + Environment.NewLine);
}

var flightQs2 = from a in flightList
                orderby a.flightFare descending
                select a;

Console.WriteLine("SBA Qs 3 Part 2. Prayas" + Environment.NewLine);

foreach (var item in flightQs2)
{
    Console.WriteLine("Flight No: " + item.flightNo);
    Console.WriteLine("Flight Name: " + item.flightName);
    Console.WriteLine("Flight Source: " + item.flightSource);
    Console.WriteLine("Flight Destination: " + item.flightDestination);
    Console.WriteLine("Flight Fare: " + item.flightFare);

    Console.WriteLine(Environment.NewLine + "-----------------------------------" + Environment.NewLine);
}


