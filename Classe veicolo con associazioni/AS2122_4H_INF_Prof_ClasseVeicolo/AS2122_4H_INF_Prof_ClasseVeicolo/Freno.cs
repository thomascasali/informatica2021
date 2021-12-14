using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ClasseVeicolo
{
    class Freno
    {
        string tipo;

        public Freno(string tipo)
        {
            this.tipo = tipo;

            Random r = new Random();
            Usura = r.Next(1, 100 + 1);
        }

        /// <summary>
        /// Ritorna l' usura del pneumatico
        /// </summary>
        public int Usura { get; set; }
    }
}
