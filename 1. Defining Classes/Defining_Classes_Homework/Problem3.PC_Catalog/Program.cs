using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3.PC_Catalog
{
    class Program
    {
        static void Main()
        {
            var processor = new Component("Processor", "the best processor", 325.38m);
            var graphicsCard = new Component("Graphics Card", "the best graphics card", 255.45m);
            var motherboard = new Component("Motherboard", "the best motherboard", 312.75m);

            var computers = new List<Computer>()
            {
                new Computer("Sony Vayo"),
                new Computer("Samsung"),
                new Computer("Macbook Pro"),
                new Computer("Acer Aspire s3")
            };

            foreach (var computer in computers)
            {
                processor.Price += 50.0m;
                graphicsCard.Price -= 20.0m;
                motherboard.Price += 100.0m;
                computer.Components.Add(processor);
                computer.Components.Add(graphicsCard);
                computer.Components.Add(motherboard);
            }

            computers.OrderBy(c => c.Price);

            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
