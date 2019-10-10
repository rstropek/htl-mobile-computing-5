using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumeWebApiConsoleApp
{
    public static partial class Program
    {
        private static HttpClient HttpClient
            = new HttpClient() { BaseAddress = new Uri("https://pokeapi.co/api/v2/") };

        public static async Task Get()
        {
            var pokemonResponse = await HttpClient.GetAsync("pokemon");
            pokemonResponse.EnsureSuccessStatusCode();
            var responseBody = await pokemonResponse.Content.ReadAsStringAsync();
            var pokemons = JsonSerializer.Deserialize<Pokemons>(responseBody);
            pokemons.Results.ForEach(p => Console.WriteLine(p.Name));
        }
    }
}
