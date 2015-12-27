using System;

namespace Problem2.Animals
{
    public class Dog : Animal
    {
        private static int count = 0;
        private static int sum = 0;

        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
            Dog.count++;
            Dog.sum += age;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Barkkkk");
        }

        public static double AverageAge
        {
            get { return (double)Dog.sum / Dog.count; }
        }
    }
}
