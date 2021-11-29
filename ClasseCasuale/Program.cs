using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCasuale
{
    class Program
    {
        static void Main(string[] args)
        {
            char risposta;
            do {
                Console.Clear();

                Casuale c = new Casuale();
                Console.WriteLine("Numero casuale: " + c.Estrai());
                Console.WriteLine("Numero casuale tra 0 e 50: " + c.Estrai(50));
                Console.WriteLine("Numero casuale tra 10 e 50: " + c.Estrai(10, 50));
                Console.ReadKey();

                CasualePari cp = new CasualePari();
                Console.WriteLine("\nNumero casuale pari: " + cp.Estrai());
                Console.WriteLine("Numero casuale pari tra 0 e 50: " + cp.Estrai(50));
                Console.WriteLine("Numero casuale pari tra 10 e 50: " + cp.Estrai(10, 50));
                Console.ReadKey();

                CasualeDispari cd = new CasualeDispari();
                Console.WriteLine("\nNumero casuale dispari: " + cd.Estrai());
                Console.WriteLine("Numero casuale dispari tra 0 e 50: " + cd.Estrai(50));
                Console.WriteLine("Numero casuale dispari tra 10 e 50: " + cd.Estrai(10, 50));
                Console.ReadKey();

                CasualePrimo cprimo = new CasualePrimo();
                Console.WriteLine("\nNumero casuale primo: " + cprimo.Estrai());
                Console.WriteLine("Numero casuale primo tra 0 e 50: " + cprimo.Estrai(50));
                Console.WriteLine("Numero casuale primo tra 10 e 50: " + cprimo.Estrai(10, 50));
                Console.WriteLine();

                Console.WriteLine("I numeri memorizzati negli oggetti sono:");
                Console.WriteLine("Casuale:  \t" + c.NumEstratto);
                Console.WriteLine("Pari:     \t" + cp.NumEstratto);
                Console.WriteLine("Dispari:  \t" + cd.NumEstratto);
                Console.WriteLine("Primo:    \t" + cprimo.NumEstratto);

                Console.WriteLine();
                Console.WriteLine("Premere S per eseguire una nuova estrazione...");

                risposta = Console.ReadKey().KeyChar;
            } while (risposta.ToString().ToUpper() == "S");
        }
    }
}
