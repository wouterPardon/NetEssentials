using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedigree
{
    class Duif
    {
        public string Ringnummer { get; set; }
        public string Kleur { get; set; }
        public string Moeder { get; set; }
        public string Vader { get; set; }
        public string Geslacht { get; set; }

        public Duif(string ringnummer, string kleur) {
            this.Ringnummer = ringnummer;

        }


    }
}
