using RestSharp;
using PokeApi.Metodos;

namespace PokeApi
{
    public class Tamagotchi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha seu pokemon!");
            
            var Pet = new ListaPokemon().GetPokemon();

            Console.WriteLine(Pet);
        }
    }
}
