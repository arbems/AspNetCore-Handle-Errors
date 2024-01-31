using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ValidationException = CleanArchitectureHandleErrors.Core.Application.Exceptions.ValidationException;

namespace CleanArchitectureHandleErrors.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        // /api/divide/1/2
        /*[HttpGet("divide/{Numerator}/{Denominator}")]
        public IActionResult Divide(double Numerator, double Denominator)
        {
            List<ValidationFailure> failures = [];
            failures.Add(new ValidationFailure("Numerator", "Numerator can not be null"));
            failures.Add(new ValidationFailure("Denominator", "Denominator can not be zero"));

            throw new ValidationException(failures);
        }*/

        [HttpGet]
        public IActionResult Get(double Numerator, double Denominator)
        {
            return Ok(Numerator / Denominator);
        }

        // /api/divide/1/2
        [HttpGet("divide/{Numerator}/{Denominator}")]
        public IActionResult Divide(double Numerator, double Denominator)
        {
            List<ValidationFailure> failures = [];

            if (Denominator == 0)
            {
                failures.Add(new ValidationFailure("Denominator", "Denominator can not be zero"));
                throw new ValidationException(failures);
            }

            return Ok(Numerator / Denominator);
        }
    }
}
