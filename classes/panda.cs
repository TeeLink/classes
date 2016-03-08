using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Panda : HasName
    {

        public string Name { get; set; }


        public Panda (string Name)
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
        public void Eat(string food)//<---argument
        {
            Console.WriteLine($"Yum, I ate {food}");
        }

        public void GoToSleep()
        {
            Console.WriteLine("The panda is sleeping...");

        }
        public void WakeUp()
        {
            Console.WriteLine("The panda has awaken...");
        }

        
        



    }
}
