using System;
using Problem2.Animals;

namespace Problem2
{
    public class Frog : Animal
    {
        private static int count = 0;
        private static int sum = 0;

        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
            Frog.count++;
            Frog.sum += age;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kva...kva...");
        }

        public static double AverageAge
        {
            get { return (double)Frog.sum / Frog.count; }
        }
    }
}
