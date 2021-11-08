using System;

using System.Collections.Generic;

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
            public DateTime data;
            public double importo;
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

            // aggiungi il movimento nell'elenco movimenti
            Movimento m = new Movimento();

            m.data = DateTime.Now;
            m.importo = importo;

            movimenti.Add(m);
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

                // aggiungi il movimento nell'elenco movimenti
                Movimento m = new Movimento();

                m.data = DateTime.Now;
                m.importo = -importo;

                movimenti.Add(m);
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
            List<Movimento> res = new List<Movimento>();

            foreach (Movimento m in movimenti)
                if (m.data > daData && m.data <= aData.AddDays(1))
                    res.Add(m);

            return res;
        }
    }
}
