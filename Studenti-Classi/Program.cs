using System;

namespace Studenti_Classi
{
    class Program
    {
        static void Main(string[] args)
        {
            Classe c = new Classe(4, "H", "Informatica");
            Studente s1 = new Studente("Primo", "Studente","1");
            Studente s2= new Studente("Secondo","Studente","2");
            Studente s3= new Studente("Terzo","Studente","3");
            c.AddStudente(s1);
            c.AddStudente(s2);
            c.AddStudente(s3);

            Console.WriteLine(s1.NomeCognome + " " + s1.Matricola);

            // altro metodo per la creazione dello studente e aggiunta nella classe
            c.AddStudente(new Studente("Quarto", "Studente","4"));

            Console.WriteLine("Elenco degli studenti della classe " + c.InfoClasse +"\n" + c.StampaStudenti());
        }
    }
}
