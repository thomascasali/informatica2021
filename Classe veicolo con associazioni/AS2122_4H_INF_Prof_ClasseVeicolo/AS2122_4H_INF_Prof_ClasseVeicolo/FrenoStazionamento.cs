using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ClasseVeicolo
{
    class FrenoStazionamento
    {
        public FrenoStazionamento()
        {
            Attivo = true;
        }

        /// <summary>
        /// Ritorna l' usura del pneumatico
        /// </summary>
        public bool Attivo { get; set; }
    }
}
