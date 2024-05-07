// See https://aka.ms/new-console-template for more information

using netflixAPI_Call;

#region Consume All Data

//movieDetails movieData = new movieDetails();

//var data = movieData.ConsumeMoviesAPI();



//foreach (var i in data)
//{

//    Console.WriteLine($"{i.movieId}. {i.movieName}");
//    Console.WriteLine($"Movie Category - {i.movieCategory}");
//    Console.WriteLine($"Movie State - {i.movieState}");
//    Console.WriteLine($"Movie Actor - {i.movieActorName}");
//    Console.WriteLine($"Movie Actress - {i.movieActress}");

//    Console.WriteLine(Environment.NewLine + "~~~~~~~~~~");


//}
#endregion

#region By Name
movieDetails movieD = new movieDetails();


Console.WriteLine("Enter Movie Name: ");
string name = Console.ReadLine();

try
{
    movieDetails movieAPI = movieD.GetMovieByName(name);

    Console.WriteLine($"{movieAPI.movieId}. {movieAPI.movieName}");
    Console.WriteLine($"Movie Category - {movieAPI.movieCategory}");
    Console.WriteLine($"Movie State - {movieAPI.movieState}");
    Console.WriteLine($"Movie Actor - {movieAPI.movieActorName}");
    Console.WriteLine($"Movie Actress - {movieAPI.movieActress}");

    Console.WriteLine(Environment.NewLine + "~~~~~~~~~~");

}
catch(Exception es) { Console.WriteLine(es.Message); }

#endregion