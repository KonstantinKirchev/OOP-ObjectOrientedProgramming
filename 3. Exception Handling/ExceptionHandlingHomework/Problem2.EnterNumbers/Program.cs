using System;
using System.Collections.Generic;

namespace Problem2.EnterNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter 10 numbers: ");
            var numbers = new List<int>();
            var startNum = 1;
            var endNum = 100;
            int i = 1;
            while (i < 11)
            {
                Console.Write("number {0}: ", i);
                try
                {
                    int num = ReadNumber(startNum, endNum);
                    numbers.Add(num);
                    startNum = num;
                    i++;
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("Please enter a number again: ");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine("Please enter a number again: ");
                }        
            }

            Console.WriteLine("The 10 numbers are: ");

            foreach (var number in numbers)
            {
                Console.Write("{0} ",number);
            }
        }

        public static int ReadNumber(int start, int end)
        {
            
            var number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number;
        }
    }
}
