using PokeApi.Classes;
using RestSharp;
using System.Text.Json;

namespace PokeApi.Metodos;

public class AcharPokemon
{
    public Pokemon GetPokemon()
    {
        var validate = 1;
        var response = new RestResponse();

        Console.WriteLine("Digite o numero da dex do pokemon que deseja:");
        var codigo = int.Parse(Console.ReadLine());
        Console.WriteLine();

        var pokemons = new RestClient($"https://pokeapi.co/api/v2/pokemon/{codigo}");
        RestRequest request = new RestRequest("", Method.Get);
        response = pokemons.Get(request);

        var Pokemon = JsonSerializer.Deserialize<Pokemon>(response.Content,
                     new JsonSerializerOptions
                     {
                         PropertyNameCaseInsensitive = true,

                     });

        return Pokemon;
    }
}
