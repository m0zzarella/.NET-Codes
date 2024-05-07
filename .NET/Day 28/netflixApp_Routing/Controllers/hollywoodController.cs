using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace netflixApp_Routing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class hollywoodController : ControllerBase
    {
        MovieDetail mObj;
        public hollywoodController(MovieDetail mObjREF)
        {
            mObj = mObjREF;
        }

        [HttpGet("ViewAllMovies")]
        public IActionResult ViewAllMovies()
        {
            var data = mObj.ViewAllMovies();
            return Ok(data);
        }

        [HttpGet("movieByCategory/{category}")]
        public IActionResult GetMovieByCategory(string category)
        {
            var data = mObj.GetMovieByCategory(category);
            return Ok(data);
        }
        [HttpGet("movieByState/{state}")]
        public IActionResult GetMovieByState(string state)
        {
            var data = mObj.GetMoviesByState(state);
            return Ok(data);
        }
        [HttpGet("movieByName/{name}")]
        public IActionResult GetMovieByName(string name)
        {
            var data = mObj.GetMovieByName(name);
            return Ok(data);
        }

        [HttpPost("AddMovie")]
        public IActionResult AddNewMovie(int mID, string mName, string mCategory, string mState, string mActor, string mActress)
        {
            var newMovie = new MovieDetail
            {
                MovieId = mID,
                MovieName = mName,
                MovieCategory = mCategory,
                MovieState = mState,
                MovieActorName = mActor,
                MovieActress = mActress
            };
            mObj.AddNewMovie(newMovie);
            return Created("", "New Movie Added!");
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var data = mObj.DeleteMovie(id);
            return Accepted(data);
        }

        [HttpPut("updateMovie/{mID}")]
        public IActionResult UpdateMovie(int mID, string mName, string mCategory, string mState, string mActor, string mActress)
        {
            var data = (from m in MovieDetail.MovieDetailsList
                        where m.MovieId == mID
                        select m).Single();

            data.MovieId = mID;
            data.MovieName = mName;
            data.MovieCategory = mCategory;
            data.MovieState = mState;
            data.MovieActorName = mActor;
            data.MovieActress = mActress;


            return Accepted(data);
        }
    }
}
