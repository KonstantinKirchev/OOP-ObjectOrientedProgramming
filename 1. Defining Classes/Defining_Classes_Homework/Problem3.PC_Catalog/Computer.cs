using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3.PC_Catalog
{
    public class Computer
    {
        private string name;
        private decimal price;
        private ICollection<Component> components;

        public Computer(string name)
        {
            this.Name = name;
            this.Price = price;
            this.Components = new HashSet<Component>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Name should be at least 5 chars long.");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public ICollection<Component> Components { get; set; }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("The name of the computer is {0}. The components are: ", Name);
            decimal sum = 0.0m;
            foreach (Component component in Components)
            {
                output.AppendFormat("{0} - {1} lv. ", component.Name, component.Price);
                sum += component.Price;
            }

            output.AppendFormat("The total price of the computer is {0} lv.", sum);
            return output.ToString();
        }
    }
}
