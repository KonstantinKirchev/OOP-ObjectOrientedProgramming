using System;
using System.Collections.Generic;
using Problem2.Animals;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            var animals = new List<Animal>
            {
                new Dog("Sharo", 5, Gender.Male),
                new Dog("Reks", 12, Gender.Male),
                new Dog("Tara", 15, Gender.Female),
                new Frog("Jap4o", 6, Gender.Male),
                new Frog("Japka", 10, Gender.Female),
                new Kitten("Katq", 4),
                new Tomcat("Tom", 8)
            };

            foreach (var animal in animals)
            {
                Console.Write("The {0} says ", animal.GetType().Name);
                animal.ProduceSound();
            }

            Console.WriteLine("The average age of dogs is {0:F2}", Dog.AverageAge);
            Console.WriteLine("The average age of frogs is {0:F2}", Frog.AverageAge);
            Console.WriteLine("The average age of kittens is {0:F2}", Kitten.AverageAge);
            Console.WriteLine("The average age of tomcats is {0:F2}", Tomcat.AverageAge);
        }
    }
}
