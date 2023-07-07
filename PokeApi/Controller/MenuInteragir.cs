using PokeApi.Models;
using PokeApi.Service;

namespace PokeApi.Controller;

public class MenuInteragir
{
    public void Interagir(List<Mascote> mascotes)
    {
        Console.WriteLine("------------------------ Interagir ------------------------");
        Console.WriteLine();

        Console.WriteLine("Digite o nome do mascote que gostaria de interagir:");
        var nome = Console.ReadLine();
        Console.WriteLine();

        var mascote = mascotes.FirstOrDefault(m => m.Especie.Name == nome);

        var jogar = 0;

        while (jogar == 0)
        {

            Console.WriteLine($"Você gostaria de: \n" +
                    $"1 - Ver como {mascote.Especie.Name} está \n" +
                    $"2 - Alimentar {mascote.Especie.Name} \n" +
                    $"3 - Brincar com {mascote.Especie.Name} \n" +
                    $"4 - Colocar {mascote.Especie.Name} para dormir\n" +
                    $"5 - Voltar");
            Console.WriteLine();

            var escolha = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (escolha)
            {
                case 1:
                    new VerMascote().Ver(mascote);
                    break;
                case 2:
                    new AlimentarMascote().Alimentar(mascote);
                    break;
                case 3:
                    new BrincarMascote().Brincar(mascote);
                    break;
                case 4:
                    new DormirMascote().Dormir(mascote);
                    break;
                case 5:
                    jogar = 1;
                    break;
                default:
                    Console.WriteLine("Entrada inválida, por favor use umas das opções listadas.");
                    break;
            }
        }
    }
}
