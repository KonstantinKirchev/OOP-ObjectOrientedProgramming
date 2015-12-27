using System;

namespace Problem1.SquareRoot
{
    class Program
    {
        static void Main()
        {
            try
            {
                var number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double sqrt = Math.Sqrt(number);
                Console.WriteLine("the square root is " + sqrt);

            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
