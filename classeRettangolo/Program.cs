using System;

namespace classeRettangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            //istanza dell'oggetto rettangolo
            Rettangolo r = new Rettangolo(10, 5);
            
            //stampa Area e Perimetro
            Console.WriteLine("Perimetro: "+r.Perimetro().ToString());
            Console.WriteLine("Area: "+r.Area().ToString());

            //provo ad impostare un lato negativo
            r.SetLato2(-10);
            //la stampa dimostra come la SetLato funziona correttamente e non permette l'immissione di valori negativi
            Console.WriteLine("Perimetro: " + r.Perimetro().ToString());
            Console.WriteLine("Area: " + r.Area().ToString());

            //utilizzo i metodi per l'impostazione dei lati
            r.SetLato1(20);
            r.SetLato2(12);
            //stampo i valori con i metodi per la lettura dei lati
            Console.WriteLine("Lato1: "+r.GetLato1() + " Lato2:" + r.GetLato2());
            Console.WriteLine("Perimetro: " + r.Perimetro().ToString());
            Console.WriteLine("Area: " + r.Area().ToString());

        }
    }
}
