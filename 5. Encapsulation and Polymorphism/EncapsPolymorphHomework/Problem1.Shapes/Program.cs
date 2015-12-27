using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Problem1.Shapes.Interfaces;
using Problem1.Shapes.Shapes;

namespace Problem1.Shapes
{
    class Program
    {
        static void Main()
        {
            var shapes = new IShape[]
            {
                new Circle(21.5),
                new Rectangle(5.5, 8.3),
                new Rhombus(4.6, 3)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("The area of {0} is {1:F2} cm.", shape.GetType().Name, shape.CalculateArea());
                Console.WriteLine("The perimeter of {0} is {1:F2} cm.", shape.GetType().Name, shape.CalculatePerimeter());
            }
        }
    }
}
