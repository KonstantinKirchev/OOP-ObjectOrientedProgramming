using System;

namespace CustomStackExample
{
    class Program
    {
        static void Main()
        {
            var stack = new CustomStack<int>();
            for (int i = 0; i < 20; i++)
            {
                stack.Push(i * 2);
            }
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Contains(18));
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.IsEmpty);
            Console.WriteLine(stack);
            //stack.Clear();
            Console.WriteLine(stack.Min());
            Console.WriteLine(stack.Max());
        }
    }
}
