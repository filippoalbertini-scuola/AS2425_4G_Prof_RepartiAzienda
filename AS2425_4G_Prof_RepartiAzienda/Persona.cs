using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2425_4G_Prof_RepartiAzienda
{
    public class Persona
    {
        string nome;
        string cognome;
        string codiceFiscale;

        string? contratto;
        Sede? sede;

        int? pagaMensile;

        public Persona(string nome, string cognome, string codiceFiscale)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.codiceFiscale = codiceFiscale;
        }

        public Sede Sede { set { sede = value; } }

        public string Contratto { set { contratto = value; } }

        public int PagaMensile { get; set; }
    }
}
