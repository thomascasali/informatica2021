using System;

namespace NetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim;
            int[,] matrice;
            dim=DimensioneMatrice();
            matrice = new int[dim, dim];
            RiempiMatrice(ref matrice);
            StampaMatrice(matrice);
            //Console.ReadKey();
        }

        static int DimensioneMatrice()
        {
            int dim;
            do
            {
                Console.WriteLine("Inserisci la dimensione della matrice");
                dim = int.Parse( Console.ReadLine());
                if (dim<=1) Console.WriteLine("La dimensione della matrice deve essere maggiore di 2");
            } while (dim < 2);
            return dim;
        }

        static void RiempiMatrice(ref int[,] mat)
        {
            var rnd = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 51);
                }
            }
        }

        static void StampaMatrice(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j]+"\t");                    
                }
                Console.WriteLine();
            }
        }


    }
}
