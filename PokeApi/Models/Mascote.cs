using PokeApi.Classes;

namespace PokeApi.Models;

public class Mascote
{
    public Pokemon Especie { get; set; }
    public int Humor { get; set; }
    public int Fome { get; set; }
    public int Sono { get; set; }

    public Mascote(Pokemon especie)
    {
        Especie = especie;
        Humor = new Random().Next(1, 10);
        Fome = new Random().Next(1, 10);
        Sono = new Random().Next(1, 10);
    }
    public override string ToString()
    {
        return Especie.ToString();
    }
}
