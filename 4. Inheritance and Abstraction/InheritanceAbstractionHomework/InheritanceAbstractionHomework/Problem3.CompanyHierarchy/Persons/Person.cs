using System;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy.Persons
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstname;
        private string lastname;

        protected Person(int id, string firstname, string lastname)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id cannot be negative.");
                }

                this.id = value;
            }
        }

        public string Firstname
        {
            get { return this.firstname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty.");
                }

                this.firstname = value;
            }
        }

        public string Lastname
        {
            get { return this.lastname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty.");
                }

                this.lastname = value;
            }
        }
    }
}
