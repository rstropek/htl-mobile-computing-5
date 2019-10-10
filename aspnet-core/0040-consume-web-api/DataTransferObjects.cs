using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConsumeWebApiConsoleApp
{
    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Pokemons
    {
        [JsonPropertyName("results")]
        public List<Pokemon> Results { get; set; }
    }
}
