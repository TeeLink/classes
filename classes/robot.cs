using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Robot
    {
        public string Name { get; set; }
        public bool IsTerminator { get; set; }

        public Robot (string Name)
        {
            this.Name = Name;
        }

        public void DisplayName()
        {
            Console.WriteLine($"My name is {Name}.");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine("Greetings!");
        }

        public void StartUp()
        {
            Console.WriteLine("Started...");
        }
        public void ShutDown()
        {
            Console.WriteLine("ShutDown...");
        }

    }
}
