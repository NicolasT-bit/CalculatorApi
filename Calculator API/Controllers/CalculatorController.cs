using Microsoft.AspNetCore.Mvc;

namespace Calculator_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class CalculatorController : Controller
    {
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            var result = a + b;
            return Ok(new { a, b, result });
        }
    }

}