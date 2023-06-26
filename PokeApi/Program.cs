using PokeApi.Classes;

namespace PokeApi
{
    public class Tamagotchi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha seu pokemon!");
            
            var Pet = new Mascote().NovoMascote();

            Console.WriteLine(Pet);
        }
    }
}
