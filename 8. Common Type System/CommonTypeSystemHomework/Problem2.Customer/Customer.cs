namespace Problem2.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Customer : IComparable<Customer>, ICloneable
    {
        public Customer(string firstname, string middlename, string lastname, string id, string permanentAddress, 
            string mobilePhone, string email, CustomerType customerType, params Payment[] payments)
        {
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.LastName = lastname;
            this.Id = id;
            this.PermanenetAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.CustomerType = customerType;
            this.Payments = new List<Payment>(payments);
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }

        public string PermanenetAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public IList<Payment> Payments { get; private set; }

        public CustomerType CustomerType { get; set; }

        public int CompareTo(Customer other)
        {
            var fullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            var otherFullName = other.FirstName + " " + other.MiddleName + " " + other.LastName;
            var result = String.Compare(fullName, otherFullName, StringComparison.InvariantCulture);

            if (result == 0)
            {
                return String.Compare(this.Id, other.Id, StringComparison.InvariantCulture);
            }

            return result;
        }

        public object Clone()
        {
            return new Customer(this.FirstName, this.MiddleName, this.LastName, this.Id, this.PermanenetAddress
                , this.MobilePhone, this.Email, this.CustomerType, this.Payments.ToArray());
        }

        public static bool operator ==(Customer c1, Customer c2)
        {
            if (object.Equals(c1, null) || object.Equals(c2, null))
            {
                return false;
            }

            return Customer.Equals(c1, c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            if (c1 == null || c2 == null)
            {
                return false;
            }

            return !(Customer.Equals(c1, c2));
        }

        public override bool Equals(object obj)
        {
            var other = obj as Customer;

            if (other == null)
            {
                return false;
            }

            return this.FirstName.Equals(other.FirstName);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.Email.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("The customer {0} {1} {2} has an EGN {3}. He lives on {4}. Payments: {5}", this.FirstName, 
                this.MiddleName, this.LastName, this.Id, this.PermanenetAddress, string.Join(", ",this.Payments.Select(p => p.ProductName)));
        }

        
    }
}
