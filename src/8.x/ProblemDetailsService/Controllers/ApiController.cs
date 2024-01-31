using Microsoft.AspNetCore.Mvc;

namespace HandleErrorsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet("divide/{Numerator}/{Denominator}")]
        public IActionResult Divide(double Numerator, double Denominator)
        {
            if (Denominator == 0)
            {
                return BadRequest();
            }

            return Ok(Numerator / Denominator);
        }
    }
}
