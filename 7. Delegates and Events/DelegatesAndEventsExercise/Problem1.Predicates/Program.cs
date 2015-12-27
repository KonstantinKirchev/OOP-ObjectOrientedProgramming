using System;
using System.Collections.Generic;

namespace Problem1.Predicates
{
    class Program
    {
        static void Main()
        {
            var collection = new List<int> { 1, 5, 6, 12, 17, 21, 9 };
            var collect = new List<string> { "Ivan", "Petkan", "Kuci"};

            Console.WriteLine(collection.FirstOrD(c => c > 7));
            Console.WriteLine(collection.FirstOrD(c => c < 0));
            Console.WriteLine(collect.FirstOrD(c => c == "Petkan"));
        }
    }
}
