using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionePacchi
{
    class Pacco
    {
        public Mittente mittente;
        public Destinatario destinatario;
        protected double altezza;
        protected double lunghezza;
        protected double larghezza;
        protected double peso;
        protected string tipo;

        public Pacco(Mittente mittente, Destinatario destinatario, double altezza, double lunghezza,double larghezza,double peso)
        {
            this.mittente=mittente;
            this.destinatario=destinatario;
            this.altezza=altezza;
            this.lunghezza=lunghezza;
            this.larghezza=larghezza;
            this.peso=peso;
        }

        public string Tipo
        {
            get { return tipo; }
        }
        protected double Volume()
        {
            return larghezza * altezza * lunghezza;
        }

        public virtual double Costo()
        {
            return 0;
        }
    }
    class PaccoCelere1 : Pacco
    {
        public PaccoCelere1(Mittente mittente, Destinatario destinatario, double altezza, double lunghezza, double larghezza, double peso) : 
            base(mittente, destinatario, altezza, lunghezza, larghezza, peso)
        {
            tipo = "Pacco Celere 1";
        }

        public override double Costo()
        {
            double costo;
            costo = Volume() * peso * 2;
            return costo;
        }
    }

    class PaccoCelere3 : Pacco
    {
        public PaccoCelere3(Mittente mittente, Destinatario destinatario, double altezza, double lunghezza, double larghezza, double peso) : base(mittente, destinatario, altezza, lunghezza, larghezza, peso)
        {
            tipo = "Pacco Celere 3";
        }

        public override double Costo()
        {
            double costo;
            costo = Volume() * peso * 1.5;
            return costo;
        }
    }

    class PaccoAssicurato : Pacco
    {
        double valoreAssicurato;
        public PaccoAssicurato(double valoreAssicurato, Mittente mittente, Destinatario destinatario, double altezza, double lunghezza, double larghezza, double peso) : base(mittente, destinatario, altezza, lunghezza, larghezza, peso)
        {
            tipo = "Pacco Assicurato";
            this.valoreAssicurato = valoreAssicurato;
        }

        public override double Costo()
        {
            double costo;
            costo = Volume() * peso * 1.5 + 10/100*valoreAssicurato;
            return costo;
        }
    }

    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public string Prov { get; set; }

        public Persona(string Nome, string Cognome, string Indirizzo, string Cap, string Citta, string Prov)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Indirizzo = Indirizzo;
            this.Cap = Cap;
            this.Citta = Citta;
            this.Prov = Prov;
        }

        public string GetInfo()
        {
            return Cognome + " " + Nome + " " + Indirizzo + " (" + Cap + ") " + Citta + " (" + Prov + ") ";
        }
    }
    
    class Mittente : Persona
    {
        public Mittente(string Nome, string Cognome, string Indirizzo, string Cap, string Citta, string Prov) :
            base(Nome, Cognome, Indirizzo, Cap, Citta, Prov)
        {
           
        }
    }

    class Destinatario : Persona
    {
        public Destinatario(string Nome, string Cognome, string Indirizzo, string Cap, string Citta, string Prov) :
            base(Nome, Cognome, Indirizzo, Cap, Citta, Prov)
        {

        }

    }
}
