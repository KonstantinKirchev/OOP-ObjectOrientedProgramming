using System;
using Problem2.Animals;

namespace Problem2
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;

        protected Animal(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }

                this.age = value;
            }
        }

        public Gender Gender { get; set; }

        public abstract void ProduceSound();
    }
}
