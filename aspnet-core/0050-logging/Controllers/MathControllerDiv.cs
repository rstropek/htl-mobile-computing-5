using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LoggingDemo.Controllers { 
    public partial class MathController {
        [HttpGet]
        [Route("div")]
        public IActionResult Div([FromQuery] int x, [FromQuery] int y)
        {
            if (y == 0) {
                _logger.LogError("Tried to divide by zero");
                return BadRequest("Division by zero not possible");
            }
            if (x % y != 0) {
                _logger.LogWarning("Non-zero remainder, possible data loss");
            }
            return Ok(x / y);
        }
    }
}
