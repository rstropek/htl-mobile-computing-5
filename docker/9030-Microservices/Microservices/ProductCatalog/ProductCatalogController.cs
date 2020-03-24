using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ProductCatalog.Controllers
{
    public class Product
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public decimal PriceExcludingVat { get; set; }

        public decimal PriceIncludingVat { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class ProductCatalogController : ControllerBase
    {
        private readonly List<Product> Products = new List<Product>
        {
            new Product { ID = 1, Description = "Foo", PriceExcludingVat = 100m },
            new Product { ID = 2, Description = "Bar", PriceExcludingVat = 200m }
        };

        private readonly ILogger<ProductCatalogController> _logger;
        private readonly IConfiguration _config;
        private readonly HttpClient _httpClient;

        public ProductCatalogController(ILogger<ProductCatalogController> logger, IConfiguration config,
            IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _config = config;
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            foreach (var product in Products)
            {
                var response = await _httpClient.GetAsync(_config["VatCalculatorUrl"] + product.PriceExcludingVat.ToString(CultureInfo.InvariantCulture));
                product.PriceIncludingVat = JsonSerializer.Deserialize<decimal>(await response.Content.ReadAsStringAsync());
            }

            return Products;
        }
    }
}
