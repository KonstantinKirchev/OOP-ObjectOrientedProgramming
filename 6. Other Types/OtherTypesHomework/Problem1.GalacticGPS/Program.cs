using System;

namespace Problem1.GalacticGPS
{
    class Program
    {
        static void Main()
        {
            var home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
