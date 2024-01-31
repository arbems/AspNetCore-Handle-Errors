using Microsoft.AspNetCore.Mvc;

namespace CustomExceptionAndAnActionFilter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet("Throw")]
        public IActionResult Throw() =>
            throw new HttpResponseException(999, "Sample exception.");
    }
}
