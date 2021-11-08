using System;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r = new Rettangolo(10, 20);
            Console.WriteLine("La super del rettangolo è " + r.Superficie().ToString());

            Parallelepipedo p = new Parallelepipedo(10, 20, 30);
            Console.WriteLine("La super del parallelepipedo è " + p.Superficie().ToString());


            // classe impiegato e manager

            Impiegato i = new Impiegato("Mario", "Rossi");
            i.IncrementaStipendio();
            Console.WriteLine("lo stipendio di " + i.CognomeNome + " è "+i.Stipendio);
            Manager m = new Manager("Super", "Manager", "Capo");
            m.IncrementaStipendio();
            Console.WriteLine("lo stipendio del manager " + m.CognomeNome + " è " + m.Stipendio);

        }
    }
}
