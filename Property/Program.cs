using System;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Thomas", "Casali", DateTime.Parse("1972-03-20"), 182);
            
            Console.WriteLine(p.Getinfo());

            Console.WriteLine($"Altezza {p.Altezza}");
            p.Altezza = -180;
            Console.WriteLine($"Altezza {p.Altezza}");
            
            Console.WriteLine($"{p.Nome} {p.Cognome} ha {p.Eta} anni");
        }
    }
}
