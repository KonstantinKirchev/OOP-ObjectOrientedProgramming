namespace Exam
{
    using Core;
    using Core.Factories;
    using IO;

    static class IsisApplication
    {
        static void Main()
        {
            var militantGroupFactory = new MilitantGroupFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new IsisData();

            var engine = new Engine(militantGroupFactory, reader, writer, data);
            engine.Run();
        }
    }
}
