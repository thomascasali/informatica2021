using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerca_lato_maggiore_matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int righe, colonne; //dichiarazione variabili per dimensione matrice
            int[,] matrice; //dichiarazione matrice
            
            do
            {
                Console.WriteLine("Inserisci il numero di righe della matrice");
                righe = int.Parse(Console.ReadLine());
            } while (righe < 2);
            do
            {
                Console.WriteLine("Inserisci il numero di colonne della matrice");
                colonne = int.Parse(Console.ReadLine());
            } while (colonne < 2);

            matrice = new int[righe, colonne]; //istanzio la matrice

            RiempiMatrice(ref matrice, 1, 10);
            StampaMatrice(matrice);

            Console.WriteLine("Il lato con la somma maggiore della matrice è {0}",LatoMaggiore(matrice));
            Console.ReadKey();
        }

        static void RiempiMatrice(ref int[,] mat, int min, int max)
        {
            var rnd = new Random();
            int r = mat.GetLength(0); //numero delle righe
            int c = mat.GetLength(1); //numero delle colonne
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    mat[i, j] = rnd.Next(min, max + 1);
                }
            }
        }

        static void StampaMatrice(int[,] mat)
        {
            int r = mat.GetLength(0); //numero delle righe
            int c = mat.GetLength(1); //numero delle colonne
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(mat[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }

        static string LatoMaggiore(int[,] mat)
        {
            int r = mat.GetLength(0); //numero delle righe
            int c = mat.GetLength(1); //numero delle colonne
            int alto=0, basso=0, destra=0, sinistra=0;
            for (int i = 0; i < r; i++)
            {
                sinistra = sinistra + mat[i, 0];
                destra = destra + mat[i, c -1];
            }
            for (int j = 0; j < c; j++)
            {
                alto = alto + mat[0, j];
                basso = basso + mat[r-1, j];
            }
            //Console.WriteLine("alto:{0}\nbasso:{1}\ndestra:{2}\nsinistra:{3}\n",alto,basso,destra,sinistra);
            if (alto > destra && alto > sinistra && alto > basso) return "ALTO";
            if (basso > destra && basso > sinistra && basso > alto) return "BASSO";
            if (sinistra> destra && sinistra > alto && sinistra > basso) return "SINISTRA";
            return "DESTRA";
        }

    }
}
