using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class panda
    {
        public string Name { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"My name is {Name}.");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine("Greetings!");
        }
        public void Eat(string food)//<---argument
        {
            Console.WriteLine($"Yum, I ate {food}");
        }

  
    }
}
