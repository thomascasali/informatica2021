using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ClasseVeicolo
{
    class Veicolo
    {
        List<Sportello> sportelli;
        List<Ruota> ruote;
        List<Freno> freni;
        FrenoStazionamento frenoStazionamento;
        Motore motore;

        public Veicolo(
            string tipoMotore, int cilindrata, string tipoFreno, int diametroRuota)
        {
            this.motore = new Motore(tipoMotore, cilindrata);

            sportelli = new List<Sportello>();
            sportelli.Add(new Sportello()); // sportelloAnterioreSx
            sportelli.Add(new Sportello()); // sportelloAnterioreDx
            sportelli.Add(new Sportello()); // sportelloPosterioreSx
            sportelli.Add(new Sportello()); // sportelloPosterioreDx
            sportelli.Add(new Sportello()); // bagagliaio

            ruote = new List<Ruota>();
            ruote.Add(new Ruota(diametroRuota)); // ruotaAnterioreSx
            ruote.Add(new Ruota(diametroRuota)); // ruotaAnterioreDx
            ruote.Add(new Ruota(diametroRuota)); // ruotaPosterioreSx
            ruote.Add(new Ruota(diametroRuota)); // ruotaPosterioreDx

            freni = new List<Freno>();
            freni.Add(new Freno(tipoFreno)); //  frenoAnterioreSx
            freni.Add(new Freno(tipoFreno)); // frenoAnterioreDx
            freni.Add(new Freno(tipoFreno)); // frenoPosterioreSx
            freni.Add(new Freno(tipoFreno)); // frenoPosterioreDx

            this.frenoStazionamento = new FrenoStazionamento();
        }

        /// <summary>
        /// apre/chiude la porta indicata
        /// </summary>
        /// <param name="sportello"></param>
        /// <param name="stato">Stato = True sportello aperto, uguale a false chiuso</param>
        public void SportelloAperto(int sportello, bool stato)
        {
            sportelli[sportello].Aperto = stato;
        }

        public void PressionePneumatico(int ruota, double pressione)
        {
            ruote[ruota].Pressione = pressione;
        }

        public void UsuraFreno(int freno, int percentuale)
        {
            freni[freno].Usura = percentuale;
        }

        /// <summary>
        /// imposta con stato Attivo e ritorna il suo stato
        /// </summary>
        /// <param name="stato"></param>
        /// <returns></returns>
        public bool FrenoStazionamento(bool stato) 
        {
            frenoStazionamento.Attivo = stato;

            return frenoStazionamento.Attivo; 
        }

        /// <summary>
        /// il veicolo si può accendere se gli sportelli sono chiusi ritorna "OK" 
        /// se il veicolo si può muovere e altrimenti KO: seguito dall'elenco dei 
        /// problemi che non lo fanno accendere separato dal carattere ; 
        /// indicando in dettaglio il componente del veicolo che genera problemi 
        /// (es KO: sportello 1 aperto; sportello 4 aperto);
        /// Se il controllo è ok accende il motore
        /// </summary>
        /// <returns></returns>
        public string Accenditi()
        {
            string controllo = "";

            // verifica se è possibile accendere il motore
            for (int i = 0;i<sportelli.Count;i++)
            {
                if (sportelli[i].Aperto==true)
                {
                    controllo = controllo + $"Sportello {i} aperto;";
                }
            }

            // verifica se accendere il motore
            if (controllo == "")
            {
                motore.Acceso = true;
                controllo = "OK";
            }
            else
            {
                motore.Acceso = false;
                controllo = "KO: " + controllo;
            }

            return controllo;
        }
        /// <summary>
        /// il veicolo si può muovere se :
        /// - il motore è acceso
        /// - tutte le ruote hanno una pressione di almeno 1,9 bar
        /// - i freni sono tutti con una percentuale di usura al massimo del 20%
        /// - il FrenoStazionamento non è attivo
        /// - gli sportelli sono tutti chiusi
        /// il metodo Muoviti() ritorna "OK" se il veicolo si può muovere e altrimenti KO: seguito dall'elenco dei problemi che non lo fanno muovere separato dal carattere ; indicando in dettaglio il componente del veicolo che genera problemi (es KO: ruota 0 pressione 1,5; veicolo spento; freno 3 usura 50%)
        /// </summary>
        /// <returns></returns>
        public string Muoviti() 
        {
            string controllo = "";

            // verifica se è possibile muovere il veicolo
            if (motore.Acceso == false)
                controllo = controllo + "Motore spento;";

            // controllo ruote
            for (int i = 0; i < ruote.Count; i++)
            {
                if (ruote[i].Pressione < 1.9)
                {
                    controllo = controllo + $"Ruota {i} con pressione troppo bassa {ruote[i].Pressione};";
                }
            }

            // controllo usura freni
            for (int i = 0; i < freni.Count; i++)
            {
                if (freni[i].Usura > 20)
                {
                    controllo = controllo + $"Freno {i} con percentuale di usura troppo alta {freni[i].Usura};";
                }
            }

            // verifica se è possibile muovere il veicolo
            if (frenoStazionamento.Attivo == true)
                controllo = controllo + "Freno di stazionamento attivo;";

            // controllo chiusura sportelli
            for (int i = 0; i < sportelli.Count; i++)
            {
                if (sportelli[i].Aperto == true)
                {
                    controllo = controllo + $"Sportello {i} aperto;";
                }
            }

            // verifica se il veicolo si può muovere
            if (controllo == "")
            {
                controllo = "OK";
            }
            else
            {
                controllo = "KO: " + controllo;
            }

            return controllo;
        }
    }
}
