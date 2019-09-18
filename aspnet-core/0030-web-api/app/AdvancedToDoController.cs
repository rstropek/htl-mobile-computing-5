using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace app
{
    public class TodoItem
    {
        [MinLength(5)]
        [MaxLength(50)]
        [Required]
        public string Description { get; set; }

        [MaxLength(50)]
        public string AssignedTo { get; set; }
    }

    [ApiController]
    [Route("api/todo-items-advanced")]
    public partial class AdvancedToDoController : ControllerBase
    {
        private static readonly List<TodoItem> items = new List<TodoItem>
        {
            new TodoItem { Description = "Clean my room", AssignedTo = "Me" },
            new TodoItem { Description = "Feed the cat", AssignedTo = "My brother" }
        };

        [HttpGet]
        public IActionResult GetAllItems()
        {
            return Ok(items);
        }

        [HttpPost]
        public IActionResult AddItem([FromBody] TodoItem newItem)
        {
            items.Add(newItem);
            return CreatedAtRoute("GetSpecificTodoItem", new { index = items.IndexOf(newItem) }, newItem);
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
