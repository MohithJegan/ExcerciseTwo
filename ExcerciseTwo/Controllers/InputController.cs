using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExcerciseTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InputController : ControllerBase
    {
        [HttpGet(template:"Lucky/{Number}")]
        public string Lucky(int Number)
        {
            return $"Entered number is {Number}";
        }

        [HttpGet(template:"Unlucky")]
        public string Unlucky(int Number)
        {
            return $"Entered number is {Number}";
        }
    }
}
