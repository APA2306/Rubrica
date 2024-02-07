using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Anelli.Alessandro._4I.rubricaUnoAMolti.Models
{
    public enum TipoContatto { nessuno, Email, Telefono, Web, Instragram }
    public class Contatto
    {
        public int  IdPersona { get; set; }
        public TipoContatto Tipo { get; set; }
        public string Valore { get; set; }

        public Contatto(string r)
        {
            string[] values = r.Split(';');
            if (values.Count() != 3)
                throw new Exception("Le righe del file contatti .csv devono essere di tre colonne");

            if (int.TryParse(values[0], out int id) && Enum.TryParse(values[1], out TipoContatto c))
                {
                    this.IdPersona = id;
                    this.Tipo = c;
                    this.Valore = values[2];
                }
        }
    }
}
