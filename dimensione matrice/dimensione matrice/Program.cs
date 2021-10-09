using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimensione_matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrice = new int[5, 4];
            Console.WriteLine(matrice.GetLength(0));
            Console.WriteLine(matrice.GetLength(1));
            Console.ReadKey();
        }
    }
}
