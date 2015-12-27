using System;

namespace Problem2.LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private int hdd;
        private string screen;
        private decimal price;

        Battery battery = new Battery();

        public Laptop(string model, decimal price)
            : this(model, price, null, null, 0, null, 0, null, null, 0.0f)
        {
            
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string graphicsCard, 
            int hdd, string screen, string name, float life)
        {
            Model = model;
            Manufacturer = manufacturer;
            Processor = processor;
            Ram = ram;
            GraphicsCard = graphicsCard;
            HDD = hdd;
            Screen = screen;
            Price = price;
            battery.Name = name;
            battery.Life = life;
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be null or empty!");
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Manufacturer cannot be empty!");
                }
                manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return processor;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Processor cannot be empty!");
                }
                processor = value;
            }
        }

        public int Ram
        {
            get
            {
                return ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("RAM cannot be negative!");
                }
                ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return graphicsCard;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Graphics Card cannot be empty!");
                }
                graphicsCard = value;
            }
        }

        public int HDD
        {
            get
            {
                return hdd;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HDD cannot be negative!");
                }
                hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return screen;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Screen cannot be empty!");
                }
                screen = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            
            if (Manufacturer == null && Processor == null && Ram == 0 && GraphicsCard == null && HDD == 0 && Screen == null 
                && battery.Name == null && battery.Life == 0.0)
            {
                return string.Format("model: {0}\nprice: {1} lv.\n", Model, Price);
            }
            return string.Format("model: {0}\nmanufacturer: {1}\nprocessor: {2}\nRAM: {3} GB\n" +
                                 "graphics card: {4}\nHDD: {5}GB SSD\nscreen: {6}\nbattery: {7}\n" +
                                 "battery life: {8} hours\nprice: {9} lv.\n",Model, Manufacturer, Processor, Ram, GraphicsCard
                                 , HDD, Screen, battery.Name, battery.Life, Price);
        }
    }
}
