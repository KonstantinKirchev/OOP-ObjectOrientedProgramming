namespace Exam.IO
{
    using System;

    using Interfaces;

    public class ConsoleWriter : IOutputWriter
    {
        public void PrintLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}
