using CustomException.Errors;
using Microsoft.AspNetCore.Mvc;

namespace HandleErrorsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string valor)
        {
            throw new HttpResponseException(999, "Sample custom exception.");
        }
    }
}
