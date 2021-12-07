Nome file consegna : AS2122_4H_INF_CognomeNome_ClasseVeicolo.zip (no bin e obj)

Modellare le classi :
- Motore con la property get/set Acceso : boolean e degli attributi tipo : string, cilindrata : integer con impostazione iniziale a Acceso = false
- Ruota con la property get/set Pressione : double e attributo diametro; nel costruttore impostare la pressione con un valore casuale da 1,5 a 2,2 (r.Next(15,22+1)/10.0)
- Freno con la property get/set Usura:integer e attributo tipo (carbonio, altro); nel costruttore impostare la percentuale di usura con un valore casuale da 0 a 100
- FrenoStazionamento con la property get/set Attivo:boolean con impostazione iniziale a Attivo = true
- Sportello con la property get/set Aperto : boolean con impostazione iniziale a Aperto = true

- Veicolo con una associazione 1 a 4 su Ruota, 1 a 5 su Sportello, 1 a 4 su Freno e 1 a 1 su Motore con i seguenti metodi :
   - Costruttore che accetta string tipoMotore, int cilindrata, string tipoFreno, int diametroRuota e crea :
      - 5 sportelli
      - 4 ruote 
      - 4 freni 
      - 1 freno di stazionamento
      - 1 motore 
   - SportelloAperto(int sportello, bool stato) : void che apre (true)/chiude (false) lo sportello indicato
   - PressionePneumatico(int ruota, double pressione) : void che imposta la pressione della ruota
   - UsuraFreno(int freno, int percentuale) : void che imposta la percentuale di usura di quel freno
   - FrenoStazionamento(bool stato): bool : imposta con true a Attivo e ritorna il suo stato
   - Accenditi() : string: il veicolo si può accendere se gli sportelli sono chiusi 
     ritorna "OK" se il veicolo si può muovere e altrimenti KO: seguito dall'elenco dei problemi che non lo fanno accendere separato dal carattere ; indicando in dettaglio il componente del veicolo che genera problemi (es KO: sportello 1 aperto; sportello 4 aperto);
   - Muoviti() : string : il veicolo si può muovere se :
      - il motore è acceso
      - tutte le ruote hanno una pressione di almeno 1,9 bar
      - i freni sono tutti con una percentuale di usura al massimo del 20%
      - il FrenoStazionamento non è attivo
      - gli sportelli sono tutti chiusi
    il metodo Muoviti() ritorna "OK" se il veicolo si può muovere e altrimenti KO: seguito dall'elenco dei problemi che non lo fanno muovere separato dal carattere ; indicando in dettaglio il componente del veicolo che genera problemi (es KO: ruota 0 pressione 1,5; veicolo spento; freno 3 usura 50%)


Le classi progettate devono funzionare con il main fornito.


Le associazioni devono essere gestite con Liste.

PLUS : al posto del numero nelle anomalie indicare la disposizione secondo lo schema sottostante.
Schema disposizione :
0 ruota AnterioreSx, 1 ruota AnterioreDx, 2 ruota PosterioreSx, 3 ruota PosterioreDx
0 freno AnterioreSx, 1 freno AnterioreDx, 2 freno PosterioreSx, 3 freno PosterioreDx
0 sportello Anteriore Sx, 1 sportello AnterioreDx, 2  sportello PosterioreSx, 3 sportello PosterioreDx, 4 sportello bagagliaio