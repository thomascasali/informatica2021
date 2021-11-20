using System;

using System.Collections.Generic;
using System.Linq;

namespace AS2122_4H_INF_Prof_ContoCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;4H Lab. 2.3;12/10/2021; Gestione conto corrente\n\n");

            ContoCorrente c = new ContoCorrente(0,"IT012345","Filippo Albertini");

            c.Versa(100);

            Console.WriteLine("Il saldo del conto corrente è ", c.GetSaldo());

            c.Preleva(10);

            Console.WriteLine("Il saldo del conto corrente è ", c.GetSaldo());

            List<ContoCorrente.Movimento> mov = new List<ContoCorrente.Movimento>();

            mov = c.GetMovimenti(DateTime.Parse("2021-10-13"), DateTime.Parse("2021-10-13"));

        }
    }

    public class ContoCorrente
    {
        double saldo;
        string iban;
        string correntista;

        public struct Movimento
        {
            public Movimento(DateTime data, double importo)
            {
                this.data = data;
                this.importo = importo;
            }
            public DateTime data { get; }
            public double importo { get; }

            public override string ToString() => $"({data}, {importo})";
        }

        List<Movimento> movimenti = new List<Movimento>();

        public ContoCorrente(double saldo, string iban, string correntista)
        {
            this.saldo = saldo;
            this.iban = iban;
            this.correntista = correntista;
        }

        /// <summary>
        /// Versa un importo sul conto corrente
        /// </summary>
        /// <param name="importo"></param>
        public void Versa(double importo)
        {
            saldo += importo;

            movimenti.Add(new Movimento(DateTime.Now, importo));
        }

        /// <summary>
        /// Preleva un importo dal conto corrente se il saldo è 
        /// maggiore uguale dell'importo da prelevare 
        /// </summary>
        /// <param name="importo"></param>
        /// <returns></returns>
        public bool Preleva(double importo)
        {
            bool res;

            if (saldo >= importo)
            {
                saldo -= importo;

                movimenti.Add(new Movimento(DateTime.Now, -importo));
                res = true;
            }
            else
                res = false;

            return res;
        }

        /// <summary>
        /// Ritorna il saldo attuale del conto corrente
        /// </summary>
        /// <returns></returns>
        public double GetSaldo()
        {
            return saldo;
        }

        /// <summary>
        /// Ritorna l'Iban del conto corrente
        /// </summary>
        /// <returns></returns>
        public string GetIban()
        {
            return iban;
        }

        public string GetCorrentista()
        {
            return correntista;
        }

        public List<Movimento> GetMovimenti(DateTime daData, DateTime aData)
        {
            //List<Movimento> result = new List<Movimento>();

            // con foreach
            //foreach (Movimento m in movimenti)
            //    if (m.data >= daData && m.data <= aData.AddDays(1))
            //        result.Add(m);

            // con LINQ
            var result = (from m in movimenti
                          where m.data >= daData && m.data <= aData.AddDays(1)
                          select m).ToList();

            return result;
;
        }
    }
}
