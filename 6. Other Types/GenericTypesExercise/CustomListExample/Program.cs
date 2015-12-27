using System;
using System.Collections.Generic;

namespace CustomListExample
{
    class Program
    {
        static void Main()
        {
            var list = new CustomList<int>();

            for (int i = 1; i <= 20; i++)
            {
                list.Add(i * 2);
            }

            list.Remove(4);

            list.Remove(7);

            list[17] = 45;

            Console.WriteLine(list.IndexOf(22));
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list);
            Console.WriteLine(list.Count());
            Console.WriteLine(list.IsEmpty());
            Console.WriteLine(list[12]);
        }
    }
}
