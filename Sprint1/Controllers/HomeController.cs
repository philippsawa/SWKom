using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sprint1.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hardcoded Response: Hello World!");
        }
    }
}
