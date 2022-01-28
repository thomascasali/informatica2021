using System;
using System.Collections.Generic;
using System.Linq;

namespace CentroVaccinazione { 
    class CentroVaccinale
    {
        public string NomeCentro { get; set; }
        public List<Malattia> Malattie;
        public List<Persona> Pazienti;
        public List<Vaccino> Vaccini;

        public CentroVaccinale(string nome)
        {
            NomeCentro = nome;
            Malattie = new List<Malattia>();
            Pazienti = new List<Persona>();
            Vaccini = new List<Vaccino>();
        }

        public void AddPaziente(Persona p)
        {
            Pazienti.Add(p);
        }

        public Persona GetPazienteFromCF(string cf)
        {
            try
            {
                Persona paz = Pazienti.First(p => p.CF == cf);
                return paz;
            }
            catch
            {
                return null;
            }

        }

        public void AddVaccino(Vaccino v)
        {
            Vaccini.Add(v);
        }
        public Vaccino GetVaccino(string nome)
        {
            try
            {
                Vaccino v = Vaccini.First(v => v.Nome == nome);
                return v;
            }
            catch
            {
                return null;
            }

        }
        public void AddMalattia(Malattia m)
        {
            Malattie.Add(m);
        }

        public Malattia GetMalattia(string nome)
        {
            try
            {
                return Malattie.First(m => m.Nome == nome);
            }
            catch
            {
                return null;
            }

        }
    }

    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CF { get; set; }

        public Persona(string nome, string cognome, string cF)
        {
            Nome = nome;
            Cognome = cognome;
            CF = cF;
        }
    }

    class Malattia
    {
        public string Nome { get; set; }
        List<Persona> Ammalati;

        public Malattia(string nome)
        {
            Ammalati = new List<Persona>();
            Nome = nome;
        }

        public void AddAmmalato(Persona p)
        {
            if (!Ammalati.Contains(p)) Ammalati.Add(p);
        }
    }

    class Vaccino
    {
        public string Nome { get; set; }
        List<Vaccinazione> Vaccinati; //lista delle persone che hanno ricevuto il vaccino
        List<Malattia> Malattie; //lista delle malattie che il vaccino previene

        public Vaccino(string nome)
        {
            Nome = nome;
            Vaccinati = new List<Vaccinazione>();
            Malattie = new List<Malattia>();
        }

        public void AddVaccinazione(Persona p)
        {
            Vaccinati.Add(new Vaccinazione(DateTime.Now, p));
        }
        public void AddVaccinazione(DateTime data, Persona p)
        {
            Vaccinati.Add(new Vaccinazione(data, p));
        }
        public void AddMalattia(Malattia m)
        {
            Malattie.Add(m);
        }

    }

    class Vaccinazione
    {
        public DateTime data { get; set; }
        public Persona paziente { get; set; }
        public Vaccinazione(DateTime data, Persona paziente)
        {
            this.data = data;
            this.paziente = paziente;
        }
    }
}
