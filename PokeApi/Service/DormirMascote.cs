using PokeApi.Models;

namespace PokeApi.Service;

public class DormirMascote
{
    public void Dormir(Mascote mascote)
    {
        if (mascote.Fome == 0)
        {
            Console.WriteLine($"{mascote.Especie.Name} está com fome, não pode dormir!");
            return;
        }
        if(mascote.Sono == 10)
        {
            Console.WriteLine($"{mascote.Especie.Name} está sem sono, não consegue dormir!");
            return;
        }

        mascote.Sono++;
        mascote.Fome--;

        Console.WriteLine($"{mascote.Especie.Name} descansou muito!");
        Console.WriteLine();
    }
}
