using System;

namespace Problem3.GenericList
{
    class Program
    {
        static void Main()
        {
            var list = new GenericList<int>();

            for (int i = 1; i <= 20; i++)
            {
                list.Add(i*2);
            }
            Console.WriteLine(list);
            Console.WriteLine(list.Count());

            list[14] = 50;

            Console.WriteLine(list);
            Console.WriteLine(list[14]);
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());

            list.Remove(1);

            Console.WriteLine(list);
            Console.WriteLine(list.Count());

            list.Insert(50, 2);
            list.Insert(33, 2);

            Console.WriteLine(list);
            Console.WriteLine(list.Count());
            Console.WriteLine(list.Contains(50));
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());

            list.Clear();

            Console.WriteLine(list.IsEmpty());
            Console.WriteLine(list);
        }
    }
}
