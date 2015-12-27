namespace Problem1.CustomExtensionMethods
{
    using System;
    using System.Collections.Generic;

    static class Program
    {
        static void Main()
        {
            var collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(string.Join(" ", collection.WhereNot(c => c % 2 == 0)));

            var students = new List<Student>
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5)
            };

            Console.WriteLine(students.Max(st => st.Grade));
        }
    }
}
