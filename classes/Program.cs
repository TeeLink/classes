using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("Rob");
            Console.WriteLine($"My name is {h.Name}.");

            Robot r = new Robot("SMSO-S515");
            Console.WriteLine($"My designation is {r.Name}.");

            Panda p = new Panda("Ettore");
            Console.WriteLine($"My name is {p.Name}.");

            Console.ReadLine();
        }
    }

   
}
