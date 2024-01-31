using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anelli.Alessandro._4I.rubricaUnoAMolti.Models
{
    internal class Persona
    {
        public int IdPersona { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Persona(string r)
        {
            string[] values = r.Split(';');
            if (int.TryParse(values[0], out int id))
            {
                this.IdPersona = id;
                this.Nome = values[1];
                this.Cognome = values[2];
            }
        }
    }
}

