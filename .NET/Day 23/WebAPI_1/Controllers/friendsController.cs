using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class friendsController : ControllerBase
    {
        static List<string> friends = new List<string>() { "Nikhil", "Akshay", "Rohan", "John", "Jane", "Elizabeth", "Rohit", "Prayas", "Ajay" };
        [HttpGet("getallfriends")]
        public IActionResult friendsClass()
        {
            //Console.WriteLine("List of all the friends");

           var getAlldata = from e in friends
                            select e;
            return Ok(getAlldata);

        }
        [HttpGet("friendbyposition/{position}")]

        public IActionResult friendbyPosition(int position)
        {
            if (position > friends.Count || position < 0)
                return Ok("No friend found at position");
            else
            {
                string friendsbyPosition = friends[position];
                return Ok($" Friend at {position} is: {friendsbyPosition}");
            }

        }


        [HttpGet("friendsbyOrder/{order}")]
        public IActionResult getfriendsbyOrder(int order) 
        { 
            if ( order == 1)
            {
                var ascendingO = from e in friends
                                 orderby e
                                 select e;
                return Ok(ascendingO);
            }
            if (order == 2)
            {
                var descendingO = from e in friends
                                 orderby e descending
                                 select e;
                return Ok(descendingO);
            }
            return Ok("Incorrect Order");
        }

        [HttpGet("countFriends")]
        public IActionResult countFriends()
        {
            var count = (from e in friends
                         select e).Count();
            return Ok("Count is: " + count);
        }

        [HttpGet("filterfriendsby/{charac}")]
        public IActionResult filterFriends(char charac)
        {
            var filter1 = (from e in friends
                         where e.StartsWith(charac)
                         select e);
            return Ok(filter1);
        }
        [HttpPut("addnewFriend/{fName}")]
        public IActionResult addFriend(string fName) 
        {
            friends.Add(fName);
            return Created("", $"{fName} has been added to friends!");
        }
        [HttpDelete("deleteFriendIndex/{position}")]
        public IActionResult removeFriendPosition(int position) 
        {
            friends.RemoveAt(position);
            return Accepted($"Friend has been deleted at {position}");
        }
        [HttpDelete("deleteFriendName/{position}")]
        public IActionResult removeFriendName(string fName)
        {
            var idx = 0;
            idx = friends.IndexOf(fName);
            if (idx == 0)
                return NotFound("User not found");
            else
            {
                friends.RemoveAt(idx);
                return Accepted($"Friend has been deleted with name {fName}");
            }
        }
        [HttpPut("editName/{position}/{newName}")]
        public IActionResult editName (int position, string newName) 
        { friends[position] = newName;
            return Ok("Name was edited");

        }

        [HttpGet("bestfriend")]
       public IActionResult GetBestFriendDetails()
        {
            Friend bestfriend = new Friend()
            {
                friendName = "",
                friendNickname = "",
                friendEmail = "",
                friendAddress = "",
                friendMobile = 0
            };
            return Ok(bestfriend);
        }

    }
}
