using System;
using System.Collections.Generic;
using System.Text;

namespace Studenti_Classi
{
    class Classe
    {
        int anno;
        string sezione;
        string indirizzo;
        List<Studente> studenti;

        public Classe()
        {
            anno = DateTime.Now.Year;
            studenti = new List<Studente>();
        }

        public Classe(int anno, string sezione, string indirizzo)
        {
            this.anno = anno;
            this.sezione = sezione;
            this.indirizzo = indirizzo;
            studenti = new List<Studente>();
        }

        public string InfoClasse
        {
            get { return anno.ToString() + sezione; }
        }
        public void AddStudente(Studente s)
        {
            studenti.Add(s);
        }

        public string StampaStudenti()
        {
            string s = "";
            foreach(Studente stud in studenti)
            {
                s = s + stud.NomeCognome + "\n";
            }
            return s;
        }
    }

    class Persona
    {
        protected string nome;
        protected string cognome;
        protected string cf;
        protected DateTime datanascita;
        protected string email;

        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        public int Eta
        {
            get { return DateTime.Now.Year - datanascita.Year; }
        }
        public string NomeCognome
        {
            get { return nome + " " + cognome; }
        }
    }

    class Studente : Persona
    {
        string matricola;
        
        public Studente(string nome, string cognome, string matricola) : base(nome,cognome)
        {
            this.matricola = matricola;
        }

        public string Matricola
        {
            get { return matricola; }
        }
    }
}
