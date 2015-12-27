using System;

namespace Problem1.BookShop
{
    class Program
    {
        static void Main()
        {
            var book = new Book("Pod Igoto", "Ivan Vazov", 15.90m);
            Console.WriteLine(book);

            var goldenBook = new GoldenEditionBook("Tutun", "Dimitur Dimov", 22.90m);
            Console.WriteLine(goldenBook);
        }
    }
}
