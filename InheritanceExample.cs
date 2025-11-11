using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    // Base class
    public class Animal
    {
        // Base class property
        public string Name { get; set; }

        // Base class method
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Derived class inheriting from Animal
    public class Dog : Animal
    {
        // Derived class method
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

    // Program class with Main method
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the derived class
            Dog myDog = new Dog();

            // Set property from base class
            myDog.Name = "Buddy";

            // Call methods
            myDog.Eat();  // Base class method
            myDog.Bark(); // Derived class method
        }
    }
}
