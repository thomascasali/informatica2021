using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_MuoviFigure
{
    #region " definizione classi "

    class Figura
    {
        protected string nome;

        // posizione
        public int Left { get; set; }
        public int Top { get; set; }

        protected double lato;

        public enum eToString
        {
            Perimetro, Area
        }

        public Figura()
        {
            nome = "Figura generica";
            Left = 0;
            Top = 0;
        }

        public virtual double Area()
        {
            return 0;
        }
        public virtual double Perimetro()
        {
            return 0;
        }

        public override string ToString()
        {
            return nome + ": area = " + Area() + " perimetro = " + Perimetro();
        }

        public string ToString(eToString tipo)
        {
            string res = "";

            switch (tipo)
            {
                case eToString.Area:
                    res = nome + ": area = " + Area();
                    break;

                case eToString.Perimetro:
                    res = nome + ": perimetro = " + Perimetro();
                    break;
            }

            return res;
        }
    }

    class Quadrato : Figura
    {
        public Quadrato(double lato) : base()
        {
            nome = "Quadrato";
            this.lato = lato;
        }

        public override double Area()
        {
            return lato * lato;
        }

        public override double Perimetro()
        {
            return lato * 4;
        }

        /// <summary>
        /// property per tornare il lato
        /// </summary>
        public double Lato
        {
            get { return lato; }
        }
    }

    class Rettangolo : Figura
    {
        double altezza;

        public Rettangolo(double b, double altezza) : base()
        {
            nome = "Rettangolo";
            lato = b;
            this.altezza = altezza;
        }

        public override double Area()
        {
            return lato * altezza;
        }

        public override double Perimetro()
        {
            return lato * 2 * altezza * 2;
        }

        /// <summary>
        /// property per tornare la base
        /// </summary>
        public double Base
        {
            get { return lato; }
        }

        /// <summary>
        /// property per tornare l'altezza
        /// </summary>
        public double Altezza
        {
            get { return altezza; }
        }
    }

    class Cerchio : Figura
    {
        public Cerchio(double raggio) : base()
        {
            nome = "Cerchio";
            lato = raggio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(lato, 2.0);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * lato;
        }
        /// <summary>
        /// property per tornare il raggio
        /// </summary>
        public double Raggio
        {
            get { return lato; }
        }
    }
    #endregion

}
