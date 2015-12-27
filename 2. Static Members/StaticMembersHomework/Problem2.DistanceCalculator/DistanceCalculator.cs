using System;
using Problem1.Point3D;

namespace Problem2.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static float CalcDistance(Point3D p1, Point3D p2)
        {
            var deltaX = p1.XCoord - p2.XCoord;
            var deltaY = p1.YCoord - p2.YCoord;
            var deltaZ = p1.ZCoord - p2.ZCoord;
            return (float) Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
        }
    }
}
