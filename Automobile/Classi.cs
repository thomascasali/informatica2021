using System;
using System.Collections.Generic;
using System.Text;

namespace Automobile
{
    class Automobile
    {
        string targa;
        DateTime dataImmatricolazione;
        public Motore motore;
        public Telaio telaio;
        public Ruota[] ruote;

        public Automobile()
        {
            ruote = new Ruota[4]; //specifico che l'automobile ha 4 ruote
        }

        public Automobile(string targa, Motore m, Telaio t, Ruota r1, Ruota r2, Ruota r3, Ruota r4)
        {
            this.targa = targa;
            dataImmatricolazione = DateTime.Now;
            motore = m;
            telaio = t;
            ruote = new Ruota[4];
            ruote[0] = r1;
            ruote[1] = r2;
            ruote[2] = r3;
            ruote[3] = r4;
        }
    }

    class Motore
    {
        int cilindrata;
        string alimentazione;

        public Motore(int cil, string alim)
        {
            cilindrata = cil;
            alimentazione = alim;
        }

        public int Cilindrata
        {
            get { return cilindrata; }
        }

        public string Alimentazione
        {
            get { return alimentazione; }
        }
    }

    class Telaio
    {
        string numTealio;
        string materiale;
        
        public Telaio()
        {
            numTealio = "00000";
            materiale = "acciaio";
        }

        public Telaio(string numTelaio, string materiale)
        {
            this.numTealio = numTelaio;
            this.materiale = materiale;
        }


        public string NumTelaio
        {
            get { return numTealio; }
        }

    }

    class Ruota
    {
        string tipo; //tradizionale, 4 stagioni, invernale
        int diametro;
        float pressione;

        public Ruota()
        {
            tipo = "tradizionale";
            diametro = 40;
        }
        public Ruota(string tipoRuota, int diametroRuota)
        {
            tipo = tipoRuota;
            diametro = diametroRuota;
            pressione = 2.9;
        }

        public string Tipo
        {
            get { return tipo; }
        }

        public int Pressione
        {
            get { return pressione; }
        }

        public int Diametro
        {
            get
            {
                return diametro;
            }

            set
            {
                if (value > 0 && value < 100) diametro = value;
            }
        }


    }

}
