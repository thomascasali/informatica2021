using System;
using System.Collections.Generic;
using System.Text;

namespace Property
{
    class Persona
    {
        //gli attributi sono tutti private
        string nome;
        string cognome;
        DateTime datan;
        int altezza;
    
        public Persona()
        {
            nome = "";
            cognome = "";
            datan = DateTime.Parse("1900-01-01");
            altezza = 0;
        }
        public Persona(string n, string c, DateTime d, int a)
        {
            nome = n;
            cognome = c;
            datan = d;
            altezza = a;
        }

        public void SetAltezza(int altezza)
        {
            this.altezza = altezza;
        }

        public string Getinfo()
        {
            return nome + " " + cognome + " (" + datan + ") " + altezza; 
        }

        public int Altezza
        {
            get
            {
                return altezza;
            }
            set
            {
                if (value < 0)
                {
                    altezza = 100;
                }
                else
                {
                    altezza = value;
                }


            }
        }

        public string Nome
        {
            get { return nome; }
        }
        public string Cognome
        {
            get { return cognome; }
        }

        public int GetEta()
        {
            var today = DateTime.Today;         
            var age = today.Year - datan.Year;
            return age;
        }

        public int Eta
        {
            get { return GetEta(); }
        }
    }


}
