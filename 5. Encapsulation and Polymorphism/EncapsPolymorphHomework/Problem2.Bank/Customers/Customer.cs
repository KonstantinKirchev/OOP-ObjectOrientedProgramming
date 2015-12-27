using System;

namespace Problem2.Bank.Customers
{
    public abstract class Customer
    {
        private string name;

        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null, empty or whitespace.");
                }

                this.name = value;
            }
        }
    }
}
