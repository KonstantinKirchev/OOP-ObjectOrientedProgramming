using System;
using Problem1.Point3D;

namespace Problem3.Paths
{
    class Program
    {
        private const string File = @"../../path.xml";

        static void Main()
        {
            var path = new Path3D(
                new Point3D(1, 2, 3),
                new Point3D(4, 5, 8),
                new Point3D(0, 0, 0),
                new Point3D(3, 12, 13));

            // Save
            Storage.SavePath(File, path);

            // Load
            Path3D path2 = Storage.LoadPath(File);

            Console.WriteLine(string.Join(Environment.NewLine, path2.Path));
        }
    }
}
