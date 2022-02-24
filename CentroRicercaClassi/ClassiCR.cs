using System;
using System.Collections.Generic;
using System.Text;

namespace CentroRicerca
{
    class CentroDiRicerca
    {
        public string Nome { get; set; }
        public List<AreaDiRicerca> aree;
    }

    class AreaDiRicerca
    {
        public string NomeArea { get; set; }
        public ResposabileArea Responsabile { get; set; }
        public List<Ricercatore> Ricercatori;
        public List<Progetto> ProgettiArea;
    }
    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

    }

    class ResposabileArea: Persona
    {
        public string Qualifica { get; set; }
    }

    class Ricercatore : Persona
    {
        public string LaureatoIn { get; set; }
        public Team TeamDiRicerca { get; }
    }

    class Junior : Ricercatore
    {
    }
    class Senior : Ricercatore
    {
    }

    class Progetto
    {
        public string NomeProgetto { get; set; }
        public Team TeamProgetto { get; set; }
    }

    class Team
    {
        public string NomeTeam { get; set; }
        public Senior ResponsabileTeam { get; set; }
        public List<Junior> RicercatoriTeam;
    }

}
