using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   public abstract class Animal
    {
        protected string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public abstract string Sound();

        public override string ToString()
        {
            return"Ik ben " + this.Name;
        }
    }
}
