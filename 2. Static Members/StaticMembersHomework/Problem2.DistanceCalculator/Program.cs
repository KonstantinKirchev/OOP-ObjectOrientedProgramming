using System;
using Problem1.Point3D;

namespace Problem2.DistanceCalculator
{
    class Program
    {
        static void Main()
        {
            var p1 = new Point3D(2, 3, 5);
            var p2 = new Point3D(3, 4, 7);
            Console.WriteLine("{0:F2}", DistanceCalculator.CalcDistance(p1,p2));
        }
    }
}
