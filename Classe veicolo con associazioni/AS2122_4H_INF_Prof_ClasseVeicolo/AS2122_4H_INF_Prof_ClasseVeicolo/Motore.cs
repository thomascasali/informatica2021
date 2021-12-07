using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ClasseVeicolo
{
    class Motore
    {
        string tipo;
        int cilindrata;

        public Motore(string tipo, int cilindrata)
        {
            this.tipo = tipo;
            this.cilindrata = cilindrata;
            Acceso = false;
        }

        /// <summary>
        /// Accende (true) o spegne (false) il motore
        /// </summary>
        public bool Acceso { get; set; }
    }
}
