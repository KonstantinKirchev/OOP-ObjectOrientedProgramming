using System;

namespace Problem1.HumanStudentAndWorker
{
    public abstract class Human
    {
        private string firstname;
        private string lastname;

        protected Human(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
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
