namespace Problem2.Func
{
    using System;
    using System.Collections.Generic;

    static class Program
    {
        static void Main()
        {
            var list = new List<int>() {1, 2, 3, 4, 5, 6, 11, 3};
            Console.WriteLine(string.Join(" ", list.TakeWhile(l => l < 10)));
        }
    }
}
