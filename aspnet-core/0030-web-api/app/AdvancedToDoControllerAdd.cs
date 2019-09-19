using Microsoft.AspNetCore.Mvc;

namespace app
{
    public partial class AdvancedToDoController
    {
        [HttpPost]
        public IActionResult AddItem([FromBody] TodoItem newItem)
        {
            items.Add(newItem);
            return CreatedAtRoute("GetSpecificTodoItem",
                new { index = items.IndexOf(newItem) }, newItem);
        }
    }
}
