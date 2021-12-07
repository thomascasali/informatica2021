using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ClasseVeicolo
{
    class Ruota
    {
        int diametro;

        public Ruota(int diametro)
        {
            this.diametro = diametro;
            Random r = new Random();
            Pressione = r.Next(12, 22+1) / 10.0;
        }

        /// <summary>
        /// Ritorna la pressione del pneumatico
        /// </summary>
        public double Pressione { get; set; }
    }
}
