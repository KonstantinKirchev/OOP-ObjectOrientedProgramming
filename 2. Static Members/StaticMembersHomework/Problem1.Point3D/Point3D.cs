using System.Runtime.CompilerServices;

namespace Problem1.Point3D
{
    public class Point3D
    {
        private static readonly Point3D StartingPointCoord;
        private int xCoord;
        private int yCoord;
        private int zCoord;

        static Point3D()
        {
            StartingPointCoord = new Point3D(0, 0, 0);
        }

        public Point3D()
            :this(0,0,0)
        {
            
        }

        public Point3D(int xCoord, int yCoord, int zCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
            this.ZCoord = zCoord;
        }

        public int XCoord
        {
            get { return this.xCoord; }
            set { this.xCoord = value; }
        }

        public int YCoord
        {
            get { return this.yCoord; }
            set { this.yCoord = value; }
        }

        public int ZCoord
        {
            get { return this.zCoord; }
            set { this.zCoord = value; }
        }

        public static Point3D StartingPoint { get { return StartingPointCoord; } }

        public override string ToString()
        {
            return string.Format("Point({0},{1},{2})", xCoord, yCoord, zCoord); ;
        }
    }
}
