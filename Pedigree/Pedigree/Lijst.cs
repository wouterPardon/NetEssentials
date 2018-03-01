using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedigree
{
    class Lijst
    {
        public Duif[] duiven = new Duif[6];

        public void Add(Duif duif)
        {
            for (int i = 0; i < duiven.Length; i++)
            {
                if (!IsPresent(duif) && duiven[i] == null)
                {
                    duiven[i] = duif;
                    break;
                }
            }
        }

        public bool IsPresent(Duif duif)
        {
            for (int i = 0; i < duiven.Length; i++)
            {
                if (duiven[i] != null) {
                    if (duif.Ringnummer.Equals(duiven[i].Ringnummer))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
