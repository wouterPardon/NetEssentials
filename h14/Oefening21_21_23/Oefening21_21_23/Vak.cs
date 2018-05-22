using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening21_21_23
{
    public class Vak
    {
        public string Naam { get; set; }
        public string NaamDocent { get; set; }
        public int Uren { get; set; }

        public Vak(string naam, string naamDocent, int uren)
        {
            Naam = naam;
            NaamDocent = naamDocent;
            Uren = uren;
        }
    }
}
