using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumeWebApiConsoleApp
{
    public static partial class Program
    {
        public static async Task Post()
        {
            var pokemon = new Pokemon { Name = "bulbasaur" };

            var content = new StringContent(JsonSerializer.Serialize(pokemon), Encoding.UTF8, "application/json");
            var pokemonResponse = await HttpClient.PostAsync("pokemon", content);
            pokemonResponse.EnsureSuccessStatusCode();
        }
    }
}
