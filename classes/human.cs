using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Human : HasName
    {
        public string Name { get; set; }
        public bool IsAsleep { get; set; }
        
        public Human (string Name)
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
        public void Eat (string pizza)
        {
                Console.WriteLine($"Yum, I ate {pizza}");
        }

        public void GoToSleep()
        {
            Console.WriteLine("is sleeping...");
        }
        public void WakeUp()
        {
            Console.WriteLine("has awaken...");
        }
        


    }
}
