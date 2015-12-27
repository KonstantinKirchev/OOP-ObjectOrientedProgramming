using System;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy.Persons.Employees
{
    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be null or empty.");
                }

                this.productName = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Date cannot be later than today.");
                }

                this.date = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} was sell on {1} for {2:F2} lv."
                , ProductName, Date, Price );
        }
    }
}
