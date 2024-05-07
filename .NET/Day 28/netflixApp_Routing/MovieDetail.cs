namespace netflixApp_Routing
{
    public class MovieDetail
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieCategory { get; set; }
        public string MovieState { get; set; }
        public string MovieActorName { get; set; }
        public string MovieActress { get; set; }

        public static List<MovieDetail> MovieDetailsList = new List<MovieDetail>();
      
        static MovieDetail()
        {

            MovieDetailsList = new List<MovieDetail>
        {
            // 10 Hollywood movies
            new MovieDetail { MovieId = 1, MovieName = "Titanic", MovieCategory = "Romance", MovieState = "Hollywood", MovieActorName = "Leonardo DiCaprio", MovieActress = "Kate Winslet" },
            new MovieDetail { MovieId = 2, MovieName = "The Matrix", MovieCategory = "SciFic", MovieState = "Hollywood", MovieActorName = "Keanu Reeves", MovieActress = "Carrie-Anne Moss" },
            new MovieDetail { MovieId = 3, MovieName = "Get Out", MovieCategory = "Horror", MovieState = "Hollywood", MovieActorName = "Daniel Kaluuya", MovieActress = "Allison Williams" },
            new MovieDetail { MovieId = 4, MovieName = "Guardians of the Galaxy", MovieCategory = "Comedy", MovieState = "Hollywood", MovieActorName = "Chris Pratt", MovieActress = "Zoe Saldana" },
            new MovieDetail { MovieId = 5, MovieName = "John Wick", MovieCategory = "Action", MovieState = "Hollywood", MovieActorName = "Keanu Reeves", MovieActress = "Halley Berry" },
            new MovieDetail { MovieId = 6, MovieName = "Gone Girl", MovieCategory = "Thriller", MovieState = "Hollywood", MovieActorName = "Ben Affleck", MovieActress = "Rosamund Pike" },
            new MovieDetail { MovieId = 7, MovieName = "The Wolf of Wall Street", MovieCategory = "Comic", MovieState = "Hollywood", MovieActorName = "Leonardo DiCaprio", MovieActress = "Margot Robbie" },
            new MovieDetail { MovieId = 8, MovieName = "La La Land", MovieCategory = "Romance", MovieState = "Hollywood", MovieActorName = "Ryan Gosling", MovieActress = "Emma Stone" },
            new MovieDetail { MovieId = 9, MovieName = "Hereditary", MovieCategory = "Horror", MovieState = "Hollywood", MovieActorName = "Alex Wolff", MovieActress = "Toni Collette" },
            new MovieDetail { MovieId = 10, MovieName = "The Social Network", MovieCategory = "Drama", MovieState = "Hollywood", MovieActorName = "Jesse Eisenberg", MovieActress = "Rooney Mara" },


            new MovieDetail { MovieId = 11, MovieName = "Dangal", MovieCategory = "Drama", MovieState = "Bollywood", MovieActorName = "Aamir Khan", MovieActress = "Fatima Sana Shaikh" },
            new MovieDetail { MovieId = 12, MovieName = "Lagaan", MovieCategory = "Drama", MovieState = "Bollywood", MovieActorName = "Aamir Khan", MovieActress = "Gracy Singh" },
            new MovieDetail { MovieId = 13, MovieName = "Gully Boy", MovieCategory = "Drama", MovieState = "Bollywood", MovieActorName = "Ranveer Singh", MovieActress = "Alia Bhatt" },
            new MovieDetail { MovieId = 14, MovieName = "Barfi!", MovieCategory = "Comedy", MovieState = "Bollywood", MovieActorName = "Ranbir Kapoor", MovieActress = "Priyanka Chopra" },
            new MovieDetail { MovieId = 15, MovieName = "Queen", MovieCategory = "Comedy", MovieState = "Bollywood", MovieActorName = "Rajkummar Rao", MovieActress = "Kangana Ranaut" },
            new MovieDetail { MovieId = 16, MovieName = "Dil Chahta Hai", MovieCategory = "Drama", MovieState = "Bollywood", MovieActorName = "Aamir Khan", MovieActress = "Preity Zinta" },
            new MovieDetail { MovieId = 17, MovieName = "Pink", MovieCategory = "Horror", MovieState = "Bollywood", MovieActorName = "Amitabh Bachchan", MovieActress = "Taapsee Pannu" },
            new MovieDetail { MovieId = 18, MovieName = "Bajrangi Bhaijaan", MovieCategory = "Drama", MovieState = "Bollywood", MovieActorName = "Salman Khan", MovieActress = "Kareena Kapoor" },
            new MovieDetail { MovieId = 19, MovieName = "Padmaavat", MovieCategory = "Thriller", MovieState = "Bollywood", MovieActorName = "Shahid Kapoor", MovieActress = "Deepika Padukone" },
            new MovieDetail { MovieId = 20, MovieName = "Uri: The Surgical Strike", MovieCategory = "Action", MovieState = "Bollywood", MovieActorName = "Vicky Kaushal", MovieActress = "Not Applicable - No lead actress" },
            
            // 10 Tollywood movies
            new MovieDetail { MovieId = 21, MovieName = "Baahubali: The Beginning", MovieCategory = "Action", MovieState = "Tollywood", MovieActorName = "Prabhas", MovieActress = "Tamannaah" },
            new MovieDetail { MovieId = 22, MovieName = "Baahubali: The Conclusion", MovieCategory = "Action", MovieState = "Tollywood", MovieActorName = "Prabhas", MovieActress = "Anushka Shetty" },
            new MovieDetail { MovieId = 23, MovieName = "Arjun Reddy", MovieCategory = "Drama", MovieState = "Tollywood", MovieActorName = "Vijay Deverakonda", MovieActress = "Shalini Pandey" },
            new MovieDetail { MovieId = 24, MovieName = "Rangasthalam", MovieCategory = "Drama", MovieState = "Tollywood", MovieActorName = "Ram Charan", MovieActress = "Samantha Akkineni" },
            new MovieDetail { MovieId = 25, MovieName = "Eega", MovieCategory = "Thriller", MovieState = "Tollywood", MovieActorName = "Nani", MovieActress = "Samantha Akkineni" },
            new MovieDetail { MovieId = 26, MovieName = "Magadheera", MovieCategory = "Romance", MovieState = "Tollywood", MovieActorName = "Ram Charan", MovieActress = "Kajal Aggarwal" },
            new MovieDetail { MovieId = 27, MovieName = "Srimanthudu", MovieCategory = "Drama", MovieState = "Tollywood", MovieActorName = "Mahesh Babu", MovieActress = "Shruti Haasan" },
            new MovieDetail { MovieId = 28, MovieName = "Geetha Govindam", MovieCategory = "Romance", MovieState = "Tollywood", MovieActorName = "Vijay Deverakonda", MovieActress = "Rashmika Mandanna" },
            new MovieDetail { MovieId = 29, MovieName = "Syeraa Narasimha Reddy", MovieCategory = "Action", MovieState = "Tollywood", MovieActorName = "Chiranjeevi", MovieActress = "Nayanthara" },
            new MovieDetail { MovieId = 30, MovieName = "Ala Vaikunthapurramuloo", MovieCategory = "Drama", MovieState = "Tollywood", MovieActorName = "Allu Arjun", MovieActress = "Pooja Hegde" },
        };
        }

        public List<MovieDetail> ViewAllMovies()
        {
            return MovieDetailsList;
        }


        public List<MovieDetail> GetMovieByCategory(string category)
        {
            var moviesByCategory = MovieDetailsList.Where(movie => movie.MovieCategory.Equals(category,StringComparison.OrdinalIgnoreCase)).ToList();
            return moviesByCategory;
        }

        public List<MovieDetail> GetMoviesByState(string state)
        {
            var moviesByState = MovieDetailsList.Where(movie => movie.MovieState.Equals(state, StringComparison.OrdinalIgnoreCase)).ToList();
            return moviesByState;
        }

        public MovieDetail GetMovieByName(string name)
        {
            return MovieDetailsList.Where(movie => movie.MovieName.Equals(name, StringComparison.OrdinalIgnoreCase)).Single();
        }

        public void AddNewMovie(MovieDetail newMovie)
        {
           
            MovieDetailsList.Add(newMovie);
        }

        public bool DeleteMovie(int movieId)
        {
            MovieDetail movieToDelete = MovieDetailsList.FirstOrDefault(movie => movie.MovieId == movieId);
            if (movieToDelete != null)
            {
                return MovieDetailsList.Remove(movieToDelete);
            }
            return false;
        }

       
    }
}
