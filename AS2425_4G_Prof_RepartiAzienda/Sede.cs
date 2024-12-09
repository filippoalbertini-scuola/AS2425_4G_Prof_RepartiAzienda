using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2425_4G_Prof_RepartiAzienda
{
    public class Sede
    {
        string citta;
        string indirizzo;
        string nome;
        Persona responsabile;

        public Sede(string citta, string indirizzo, string nome)
        {
            this.citta = citta;
            this.indirizzo = indirizzo;
            this.nome = nome;
        }

        public Persona Responsabile {  set { responsabile = value; } }
    }
}
