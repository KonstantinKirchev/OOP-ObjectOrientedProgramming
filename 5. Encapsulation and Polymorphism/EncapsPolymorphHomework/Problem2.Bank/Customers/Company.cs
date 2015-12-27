using System;

namespace Problem2.Bank.Customers
{
    public class Company : Customer
    {
        private string bulstad;

        public Company(string name, string bulstad) 
            : base(name)
        {
            this.Bulstad = bulstad;
        }

        public string Bulstad
        {
            get { return this.bulstad; }
            set
            {
                if (value.Length != 8)
                {
                    throw new ArgumentException("Bulstad should be exactly 8 characters long.");
                }

                this.bulstad = value;
            }
        }
    }
}
