using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace LoggingDemo.Controllers
{
    public partial class MathController
    {
        [HttpGet]
        [Route("divEx")]
        public IActionResult DivEx([FromQuery] int x, [FromQuery] int y)
        {
            try { return Ok(x / y); }
            catch (DivideByZeroException ex)
            {
                _logger.LogError(ex, "Tried to divide {x} by zero", x);
                return BadRequest("Division by zero not possible");
            }
        }
    }
}
