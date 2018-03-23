using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class SmallDogo : Animal
    {
        public SmallDogo(string name) : base(name)
        {

        }

        public override string Sound()
        {
            return "Waf Waf";
        }
    }
}
