using PokeApi.Models;

namespace PokeApi.Service;

public class AlimentarMascote
{
    public void Alimentar(Mascote mascote)
    {
        if (mascote.Fome == 10)
        {
            Console.WriteLine($"{mascote.Especie.Name} está sem fome, não pode comer!");
            return;
        }

        if (mascote.Humor != 0)
        {
            mascote.Humor--;
        }

        mascote.Fome++;

        Console.WriteLine($"{mascote.Especie.Name} comeu bastente.");
        Console.WriteLine();
    }
}
