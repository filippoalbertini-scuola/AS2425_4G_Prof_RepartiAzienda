using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2425_4G_Prof_RepartiAzienda
{
    public class Reparto
    {
        Persona? responsabile;
        List<Persona> personale;
        string nome;

        public List<Persona> Personale { get { return personale; } }

        public Reparto(string nome)
        {
            this.nome = nome;
            personale = new List<Persona>();
        }

        public void AddPersona(Persona persona)
        { 
            personale.Add(persona);
        }

        /// <summary>
        /// Costo mensile dipendenti + responsabile
        /// </summary>
        /// <returns></returns>
        public long CostoMensile()
        { 
            return 0; 
        }

    }

}
