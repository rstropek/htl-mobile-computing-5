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
}
