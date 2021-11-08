using System;
using System.Collections.Generic;
using System.Text;

namespace Overriding
{
    class Rettangolo
    {
        protected float b;
        protected float h;

        public Rettangolo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        public virtual float Superficie() {
            return b * h;
        }
        public float Vernice(float costo)
        {
            return b*h*costo;
        }
    }

    class Parallelepipedo: Rettangolo
    {
        float hP;

        //costruttore
        public Parallelepipedo(float b, float h, float hP) : base(b, h)
        {
            this.hP = hP;
        }

        public override float Superficie()
        {
            return 2 * b * h + 2 * (b + h) * hP;
        }

        public float Vernice(float costo1, float costo2)
        {
            return Vernice(costo1) + 2 * (b + h) * hP * costo2;
        }
    }

    // impiegato e manager

    class Impiegato
    {
        protected string nome;
        protected string cognome;
        protected string CF;
        protected DateTime dataN;
        protected double stipendio;

        public Impiegato(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            stipendio = 1500;
        }

        public string CognomeNome
        {
            get { return cognome + " " + nome; }
        }

        public double Stipendio
        {
            get { return stipendio; }
        }

        public virtual void IncrementaStipendio() {
            stipendio = stipendio + stipendio * 10 / 100;
        }
    }

    class Manager : Impiegato
    {
        string ruolo;

        public Manager(string nome, string cognome, string ruolo) : base(nome, cognome)
        {
            this.ruolo = ruolo;
            stipendio = 2000;
        }

        public override void IncrementaStipendio()
        {
            stipendio = stipendio + stipendio * 20 / 100;
        }
    }
}
