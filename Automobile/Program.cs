using System;

namespace Automobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Ruota ruota1 = new Ruota("invernale", 45);
            Ruota ruota2 = new Ruota("invernale", 45);
            Ruota ruota3 = new Ruota("invernale", 45);
            Automobile a = new Automobile("DZ122RS",new Motore(1600, "benzina"),new Telaio(),ruota1,ruota2,ruota3, new Ruota("invernale", 45));
            Console.WriteLine("Cilindrata del motore: " + a.Motore.Cilindrata);
            Console.WriteLine("Pressione della terza ruota: " + a.Ruote[2].Pressione);

        }
    }
}
