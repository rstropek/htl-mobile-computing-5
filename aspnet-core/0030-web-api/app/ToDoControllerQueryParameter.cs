using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace app {
    public partial class ToDoController {
        [HttpGet]
        [Route("sorted")]
        public IActionResult GetAllItemsSorted([FromQuery]string sortOrder) {
            return sortOrder switch {
                "desc" => Ok(items.OrderByDescending(item => item)),
                "asc" => Ok(items.OrderBy(item => item)),
                _ => BadRequest("Invalid or missing sortOrder query parameter")
            };
        }
    }
}
