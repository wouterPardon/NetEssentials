using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Pleas enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hi there " + name);
            Console.ReadLine();
        }
    }
}
