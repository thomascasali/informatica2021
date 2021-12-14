using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionePacchi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pacco> pacchi = new List<Pacco>();
            //...... completare......


            Mittente mit = new Mittente("thomas","casali","via roma","47023","Cesena","FC");
            Destinatario des = new Destinatario("mario", "rossi", "via bologna", "47900", "Rimini", "RN");
            PaccoCelere1 pc1 = new PaccoCelere1(mit, des, 10, 10, 10, 1);
            Console.WriteLine(pc1.Tipo + ":");
            Console.WriteLine("Mittente: " + pc1.mittente.GetInfo());
            Console.WriteLine("Destinatario: "+ pc1.destinatario.GetInfo());
            Console.WriteLine("Costo spedizione: " + pc1.Costo());
            Console.WriteLine();

            PaccoCelere3 pc3 = new PaccoCelere3(mit, des, 10, 10, 10, 1);
            Console.WriteLine(pc3.Tipo + ":");
            Console.WriteLine("Mittente: " + pc3.mittente.GetInfo());
            Console.WriteLine("Destinatario: " + pc3.destinatario.GetInfo());
            Console.WriteLine("Costo spedizione: " + pc3.Costo());

            Console.ReadKey();
        }
    }
}
