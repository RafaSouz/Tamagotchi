using PokeApi.Models;

namespace PokeApi.Service;

public class BrincarMascote
{
    public void Brincar(Mascote mascote)
    {
     
        if (mascote.Sono == 0)
        {
            Console.WriteLine($"{mascote.Especie.Name} está com sono, não pode brincar!");
            return;
        }

        if (mascote.Humor != 10)
        {
            mascote.Humor++;
        }

        mascote.Sono--;

        Console.WriteLine($"{mascote.Especie.Name} brincou até se cansar!");
        Console.WriteLine();
    }
}
