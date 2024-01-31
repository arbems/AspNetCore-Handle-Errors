using Microsoft.AspNetCore.Mvc;

namespace HandleErrorsAspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        // /api/divide/1/2
        [HttpGet("divide/{Numerator}/{Denominator}")]
        public IActionResult Divide(double Numerator, double Denominator)
        {
            if (Denominator == 0)
            {
                throw new NotImplementedException();
            }

            return Ok(Numerator / Denominator);
        }
    }
}
