namespace Problem3.Action
{
    using System;
    using System.Collections.Generic;

    static class Program
    {
        static void Main()
        {
            var collection = new List<int>() {1, 2, 3, 4, 5, 6, 11, 3};
            collection.MyForEach(Console.WriteLine);
        }
    }
}
