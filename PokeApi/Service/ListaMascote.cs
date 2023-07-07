using PokeApi.Classes;
using PokeApi.Models;

namespace PokeApi.Service;

public class ListaMascote
{
    public void Listar(List<Mascote> mascotes)
    {
        foreach (Mascote m in mascotes)
        {
            Console.WriteLine(m.ToString());
            Console.WriteLine();
        }
    }
}
