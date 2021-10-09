using System;
using System.Collections.Generic;
using System.Text;

namespace firstClass
{
    class Persona
    {
        public string nome;
        public string cognome;
        public int altezza;
        public DateTime dataNascita;
        string indirizzo;

        public Persona(string nome,string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        public Persona(string nome)
        {
            this.nome = nome;
            this.cognome = "";
        }

        public Persona()
        {
            this.nome = "";
            this.cognome = "";
        }

        public Persona(string nome, string cognome, int a)
        {
            this.nome = nome;
            this.cognome = cognome;
            altezza = a;
        }
        public string GetInfo()
        {
            return this.nome + " " + this.cognome + " - altezza: " + this.altezza + ", indirizzo: " + this.indirizzo;
        }
        public void ModificaIndirizzo(string ind)
        {
            this.indirizzo = ind;
        }
    }

    class Triangolo
    {
        double l1;
        double l2;
        double l3;

        public Triangolo(double l)
        {
            l1 = l;
            l2 = l;
            l3 = l;
        }

        public Triangolo(double l1, double l2)
        {
            this.l1 = l1;
            this.l2 = l2;
            l3 = l1;
        }

        public Triangolo(double l1, double l2, double l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public double Perimetro()
        {
            return l1 + l2 + l3;
        }

        public string GetInfoTriangolo() { 
            return "Lato1: " + l1 + ",Lato2: " + l2 + ",Lato3: " + l3 +", Perimetro: " + this.Perimetro();
        }
    }
}
