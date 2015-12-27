using System;

namespace Problem1.Persons
{
    class Program
    {
        static void Main()
        {
            var person1 = new Person("Pesho", 32);
            var person2 = new Person("Gosho", 23, "gosho@gmail.com");
            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
