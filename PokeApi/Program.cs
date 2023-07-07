using PokeApi.Controller;
using PokeApi.Models;

namespace PokeApi;

public class Tamagotchi
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual seu nome?");
        var Nome = Console.ReadLine();
        var Mascotes = new List<Mascote>();

        new Menu().Iniciar(Nome,Mascotes);
    }
}
