using System;

namespace Problem2.Animals
{
    public abstract class Cat : Animal
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miauuuu");
        }
    }
}
