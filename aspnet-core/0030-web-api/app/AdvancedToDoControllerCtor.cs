using Microsoft.Extensions.Configuration;

namespace app { 
    public partial class AdvancedToDoController {
        public AdvancedToDoController(IConfiguration configuration) {
            if (items.Count == 0) {
                var countSetting = configuration["NumberOfInitialItems"];
                if (!int.TryParse(countSetting, out var numberOfInitialItems)) {
                    numberOfInitialItems = 3;
                }

                for (var i = 0; i < numberOfInitialItems; i++) {
                    items.Add(new TodoItem { Description = $"Item {i + 1}", 
                        AssignedTo = "Me" });
                }
            }
        }
    }
}
