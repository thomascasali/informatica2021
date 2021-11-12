using System;

namespace Studenti_Classi
{
    class Program
    {
        static void Main(string[] args)
        {
            Classe c = new Classe(4, "H", "Informatica");
            Studente s1 = new Studente("Primo", "Studente");
            Studente s2= new Studente("Secondo","Studente");
            Studente s3= new Studente("Terzo","Studente");
            c.AddStudente(s1);
            c.AddStudente(s2);
            c.AddStudente(s3);

            // altro metodo per la creazione dello studente e aggiunta nella classe
            c.AddStudente(new Studente("Quarto", "Studente"));

            Console.WriteLine("Elenco degli studenti della classe " + c.InfoClasse +"\n" + c.StampaStudenti());
        }
    }
}
