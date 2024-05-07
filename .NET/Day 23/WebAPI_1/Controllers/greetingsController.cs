using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class greetingsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GreetUser()
        {
            return Ok("Hello and Welcome to Web Dev");

        }
        [HttpGet("greetuser")]
        public IActionResult greetings(string name)
        {
            string message = "Hello " + name;
            return Ok(message);
        }

        [HttpGet("addition")]
        public IActionResult addition(int num1, int num2)
        {
            int addResult = num1 + num2;
            return Ok($"Result of {num1} + {num2} is: {addResult}");
        }
        [HttpGet("calculate")]
        public IActionResult calculate(int num1, int num2, string  operation)
        {
            double result = 0;
            if (operation == "+")
                result = num1 + num2;
            else if (operation =="-")
                result = num1 - num2;
            else if (operation == "*")
                result = num1 * num2;
            else if (operation == "/")
                result = num1 / num2;


            return Ok($"Hello, result of {num1} {operation} {num2} is: {result}");
        }

    }
}
