using System;

namespace Problem3.PC_Catalog
{
    public class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, string details, decimal price)
        {
            Name = name;
            Details = details;
            Price = price;
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

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
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
    }
}
