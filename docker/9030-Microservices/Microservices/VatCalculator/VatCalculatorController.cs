using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VatCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VatCalculatorController : ControllerBase
    {
        private readonly ILogger<VatCalculatorController> _logger;

        public VatCalculatorController(ILogger<VatCalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public decimal Get([FromQuery]decimal priceExcludingVat)
        {
            return priceExcludingVat * 1.2m;
        }
    }
}
