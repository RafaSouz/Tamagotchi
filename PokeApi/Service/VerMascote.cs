using PokeApi.Models;

namespace PokeApi.Service;

public class VerMascote
{
    public void Ver(Mascote mascote)
    {
        mascote.ToString();

        if(mascote.Sono < 5 )
        {
            Console.WriteLine($"{mascote.Especie.Name} está com soninho...");
        }

        if(mascote.Fome < 5 ) 
        {
            Console.WriteLine($"{mascote.Especie.Name} está com a barriga roncando!");
        }

        if(mascote.Humor < 5)
        {
            Console.WriteLine($"{mascote.Especie.Name} está mal humorado.");
        }

        if (mascote.Fome >= 5 && mascote.Humor >= 5 && mascote.Sono >= 5)
        {
            Console.WriteLine($"{mascote.Especie.Name} está de boa na lagoa!");
        }

        Console.WriteLine();
    }
}
