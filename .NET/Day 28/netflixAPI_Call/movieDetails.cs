using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixAPI_Call
{
    internal class movieDetails
    {
        public int movieId { get; set; }
        public string movieName { get; set; }
        public string movieCategory { get; set; }
        public string movieState { get; set; }
        public string movieActorName { get; set; }
        public string movieActress { get; set; }
        public List<movieDetails> ConsumeMoviesAPI()
        {
            string url = "https://localhost:7090/api/action/ViewAllMovies/";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var call = client.GetAsync(url);
            var response = call.Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var data = response.Content;

                List<movieDetails> moviesdata = data.ReadAsAsync<List<movieDetails>>().Result;

                call.Wait();
                return moviesdata;


            }
            else
            {
                throw new Exception("Comments cannot be fetched");
            }
        }
        public movieDetails GetMovieByName(string movieName)
        {

            string url = "https://localhost:7090/api/action/movieByName/" + movieName;

            HttpClient client = new HttpClient(); client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            var call = client.GetAsync(url);

            var response = call.Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var data = response.Content;

                movieDetails result = data.ReadAsAsync<movieDetails>().Result; call.Wait();

                return result;
            }

            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound) ;

            throw new Exception("PLease contact Admin");
        }

    }
}
