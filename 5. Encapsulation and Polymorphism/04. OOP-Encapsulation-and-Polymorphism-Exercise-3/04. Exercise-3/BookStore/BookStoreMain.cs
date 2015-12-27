using BookStore.Interfaces;
using BookStore.UI;

namespace BookStore
{
    using Engine;

    public class BookStoreMain
    {
        public static void Main()
        {
            var consoleRenderer = new ConsoleRenderer();
            var consoleInputHandler = new ConsoleInputHandler();

            BookStoreEngine engine = new BookStoreEngine(consoleRenderer, consoleInputHandler);

            engine.Run();
        }
    }
}
