using PokeApi.View;
using PokeApi.Service;
using PokeApi.Models;

namespace PokeApi.Controller;

public class Menu
{
    public void Iniciar(string nome, List<Mascote> mascotes)
    {
        var jogar = 0;

        while (jogar == 0)
        {
            Console.WriteLine("-------------------------- Menu --------------------------");

            Console.WriteLine();

            Console.WriteLine($"{nome}, você gostaria de: \n" +
                $"1 - Adotar um mascote \n" +
                $"2 - Ver seus mascotes \n" +
                $"3 - Interagir com um mascote \n" +
                $"4 - Sair");
            Console.WriteLine();

            var escolha = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (escolha)
            {
                case 1:
                    new MenuAdotar().Adotar(mascotes);
                    break;
                case 2:
                    new ListaMascote().Listar(mascotes);
                    break;
                case 3:
                    new MenuInteragir().Interagir(mascotes);
                    break;
                case 4:
                    jogar = 1;
                    break;
                default:
                    Console.WriteLine("Entrada inválida, por favor use umas das opções listadas.");
                    break;
            }
        }
    }
}
