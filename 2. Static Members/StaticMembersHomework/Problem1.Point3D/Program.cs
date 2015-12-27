using System;

namespace Problem1.Point3D
{
    class Program
    {
        static void Main()
        {
            var point1 = new Point3D(5, 3, 6);
            var point2 = new Point3D();
            Console.WriteLine(Point3D.StartingPoint);
            Console.WriteLine(point1);
            Console.WriteLine(point2);
        }
    }
}
