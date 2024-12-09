using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2425_4G_Prof_RepartiAzienda
{
    public class Azienda
    {
        string nome;
        System.Collections.Generic.List<Reparto> reparti;
        List<Sede> sedi;
        Persona ceo;

        public Azienda(string nome)
        {
            this.nome = nome;
            this.reparti = new List<Reparto>();
            this.sedi = new List<Sede>();
        }

        public void AddSede(Sede sede)
        {
            sedi.Add(sede);
        }

        public void AddReparto(Reparto reparto)
        {
            reparti.Add(reparto);
        }

        public Persona Ceo { set { ceo = value; } }

        /// <summary>
        /// Costo mensile reparti + Ceo
        /// </summary>
        /// <returns></returns>
        public long CostoMensile()
        {
            return 0;
        }

    }
}
