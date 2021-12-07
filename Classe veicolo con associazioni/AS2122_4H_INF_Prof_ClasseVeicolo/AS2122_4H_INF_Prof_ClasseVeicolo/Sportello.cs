using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ClasseVeicolo
{
    class Sportello
    {
        public Sportello()
        {
            Aperto = true;
        }

        /// <summary>
        /// Ritorna l' usura del pneumatico
        /// </summary>
        public bool Aperto { get; set; }
    }
}
