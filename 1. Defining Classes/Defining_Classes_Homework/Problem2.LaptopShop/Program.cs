using System;

namespace Problem2.LaptopShop
{
    class Program
    {
        static void Main()
        {
            var computer = new Laptop("HP 250 G2", 699.00m);
            var laptop = new Laptop("Lenovo Yoga 2 Pro", 2259.00m, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8, "Intel HD Graphics 4400", 128, "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display", "Li-Ion, 4-cells, 2550 mAh", 4.5f);
            Console.WriteLine(computer);
            Console.WriteLine(laptop);
        }
    }
}
