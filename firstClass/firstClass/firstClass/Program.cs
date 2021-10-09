using System;

namespace firstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p;
            p = new Persona();
            p.nome = "Thomas";
            p.cognome = "Casali";
            p.altezza = 182;
            p.ModificaIndirizzo("Viale Roma 27");
            Console.WriteLine(p.GetInfo());
            
            Persona p1 = new Persona();
            p1.nome = "Pietro";
            p1.cognome= "Astorino";
            p1.altezza = 180;
            Console.WriteLine(p1.GetInfo());

            Persona p2 = new Persona("Gianni");
            Console.WriteLine(p2.GetInfo());

            Persona p3 = new Persona("Giorgio", "Rossi");
            Console.WriteLine(p3.GetInfo());

            Console.WriteLine();
            Console.WriteLine("-------------------");

            Triangolo t1 = new Triangolo(10);
            Console.WriteLine("Perimetro di t1="+t1.Perimetro());

            Triangolo t2 = new Triangolo(10,15);
            Console.WriteLine("Perimetro di t2=" + t2.Perimetro());

            Triangolo t3 = new Triangolo(10,15,20);
            Console.WriteLine("Perimetro di t3=" + t3.Perimetro());

            Console.WriteLine(t3.GetInfoTriangolo());

            Console.ReadKey();

        }
    }
}
