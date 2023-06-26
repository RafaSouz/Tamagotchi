using PokeApi.Classes;
using RestSharp;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PokeApi.Metodos;

public class ListaPokemon
{
    public Mascote GetPokemon()
    {
        var validate = 1;
        var response = new RestResponse();

        while (validate == 1)
        {
            Console.WriteLine("Digite o numero da dex do pokemon que deseja:");
            var codigo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var pokemons = new RestClient($"https://pokeapi.co/api/v2/pokemon/{codigo}");
            RestRequest request = new RestRequest("", Method.Get);
            response = pokemons.Get(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = JsonSerializer.Deserialize<Mascote>(response.Content,
                     new JsonSerializerOptions
                     {
                         PropertyNameCaseInsensitive = true,
                         
                     });

                Console.WriteLine(json.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Digite 0 para escolher esse pokemon ou 1 para escolher outro:");
            validate = int.Parse(Console.ReadLine());
            Console.WriteLine();

        }

        var Pokemon = JsonSerializer.Deserialize<Mascote>(response.Content,
                     new JsonSerializerOptions
                     {
                         PropertyNameCaseInsensitive = true,

                     });

        return Pokemon;
    }
}
