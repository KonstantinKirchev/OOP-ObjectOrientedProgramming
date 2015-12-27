using System;

namespace Problem1.Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

       

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

         public Person(string name, int age)
            : this(name, age, null)
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The age should be in the range [1..100]");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("This email is not valid. It should contain \"@\".");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            if (Email == null)
            {
                return string.Format("My name is {0}. I am {1} years old and I don't have email.", Name, Age);
            }
            return string.Format("My name is {0}. I am {1} years old and my email is {2}.", Name, Age, Email);
        }
    }
}
