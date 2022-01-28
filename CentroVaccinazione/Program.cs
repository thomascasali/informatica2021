using System;

namespace CentroVaccinazione
{
    class Program
    {
        static void Main(string[] args)
        {
            var cv = new CentroVaccinale("Hub Rimini");
            cv.AddPaziente(new Persona("Mario", "Rossi", "MARIO"));
            cv.AddPaziente(new Persona("Paolo", "Bianchi", "PAOLO"));
            cv.AddVaccino(new Vaccino("Pfizer"));
            cv.AddMalattia(new Malattia("Covid-19"));

            //cerco il paziente Mario
            Persona p = cv.GetPazienteFromCF("MARIO");
            if (p != null)
            {   //se Mario esiste procedo...
                Console.WriteLine(p.Nome);

                //vacciniamo Mario
                cv.GetVaccino("Pfizer").AddVaccinazione(p);

                //ammaliamo Mario
                cv.GetMalattia("Covid-19").AddAmmalato(p);
            }
            else
            {
                Console.WriteLine("Il paziente non esiste");
            }
        }
    }
}