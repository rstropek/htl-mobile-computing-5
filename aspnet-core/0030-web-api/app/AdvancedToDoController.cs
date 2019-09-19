using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace app
{
    [ApiController]
    [Route("api/todo-items-advanced")]
    public partial class AdvancedToDoController : ControllerBase
    {
        private static List<TodoItem> items = new List<TodoItem>();

        [HttpGet]
        public IActionResult GetAllItems()
        {
            return Ok(items);
        }

        [HttpDelete]
        [Route("{index}")]
        public IActionResult DeleteItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
                return NoContent();
            }

            return BadRequest("Invalid index");
        }

        [HttpGet]
        [Route("{index}", Name = "GetSpecificTodoItem")]
        public IActionResult GetItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return Ok(items[index]);
            }

            return BadRequest("Invalid index");
        }

        [HttpPut]
        [Route("{index}")]
        public IActionResult UpdateItem(int index, [FromBody] TodoItem newItem)
        {
            if (index >= 0 && index < items.Count)
            {
                items[index] = newItem;
                return Ok();
            }

            return BadRequest("Invalid index");
        }
    }
}
