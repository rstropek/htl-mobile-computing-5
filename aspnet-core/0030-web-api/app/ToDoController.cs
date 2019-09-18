using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace app
{
    [ApiController]
    [Route("api/todo-items")]
    public partial class ToDoController : ControllerBase
    {
        private static readonly List<string> items = new List<String> { "Clean my room", "Feed the cat" };

        [HttpGet]
        public IActionResult GetAllItems()
        {
            return Ok(items);
        }
    }
}
