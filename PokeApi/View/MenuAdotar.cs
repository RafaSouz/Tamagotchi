using PokeApi.Metodos;
using PokeApi.Models;

namespace PokeApi.View;

public class MenuAdotar
{
    public void Adotar(List<Mascote> mascotes)
    {
        Console.WriteLine("Escolha seu mascote!");

        while (true)
        {
            var mascote = new AcharPokemon().GetPokemon();

            if(mascote == null)
            {
                Console.WriteLine("API está fora do ar, por favor tente novamente mais tarde... ");
                break;
            }

            Console.WriteLine($"Gostaria de ver detalhes de {mascote.Name}? Sim ou Nao");
            var escolha = Console.ReadLine();
            Console.WriteLine();

            if (escolha == "Sim")
            {
                Console.WriteLine(mascote.ToString());
            }

            Console.WriteLine($"Gostaria de adotar {mascote.Name}? Sim ou Nao");
            escolha = Console.ReadLine();
            Console.WriteLine();

            if (escolha == "Sim")
            {
                mascotes.Add(new Mascote(mascote));
                Console.WriteLine($"{mascote.Name} foi adotado e está muito feliz!");
                Console.WriteLine();
                break;
            }
        }
    }
}
