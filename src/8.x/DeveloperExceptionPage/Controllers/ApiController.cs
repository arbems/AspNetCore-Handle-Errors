using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace HandleErrorsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet("Throw")]
        public IActionResult Throw() => 
            throw new Exception("Sample exception.");
    }
}
