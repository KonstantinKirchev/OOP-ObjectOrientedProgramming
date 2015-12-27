using System;
using System.Collections.Generic;

namespace Problem1.ValidPerson
{
    class Program
    {
        static void Main()
        {
            //var persons = new List<Person>()
            //{
            //    new Person("Pesho", "Peshev", 23),
            //    new Person("Gosho", string.Empty, 23),
            //    new Person(string.Empty, "Peshev", 23),
            //    new Person("Kiro", "Peshev", -23)
            //};
            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            //try
            //{
            //    var person = new Person(string.Empty, "Kirchev", 33);
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine("Exception thrown: {0}", ex.Message);
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine("Exception thrown: {0}", ex.Message);
            //}

            try
            {
                var person = new Person("Konstantin", "Kirchev", 123);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
        }
    }
}
