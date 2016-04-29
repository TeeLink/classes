using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Human : Mammal, IHasName
    {
        public string Name { get; set; }
        public bool IsAsleep { get; set; }

        public Human(string name)
        {
            this.Name = name;
        }

        public override void Bathe()
        {
            Console.WriteLine($"{Name} bathes in the tub.");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} play in the gym.");
        }

        public void DisplayName()
        {
            Console.WriteLine($"My name is {Name}.");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine("Greetings!");
        }

        public void Eat(string pizza)
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





