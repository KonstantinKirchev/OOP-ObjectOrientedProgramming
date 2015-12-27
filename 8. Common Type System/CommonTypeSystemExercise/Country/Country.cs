namespace Country
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Country : IComparable<Country>, ICloneable
    {
        private string name;
        private double area;
         
        public Country(string name, ulong population, double area, params string[] cities)
        {
            this.Name = name;
            this.Population = population;
            this.Area = area;
            this.Cities = new HashSet<string>(cities);
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
                    throw new ArgumentNullException("Country name cannot be null, empty or whitespace.");
                }
                this.name = value;
            }
        }

        public ulong Population { get; set; }

        public double Area
        {
            get
            {
                return this.area;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("area","The area of the country cannot be negative.");
                }
                this.area = value;
            }
        }

        public HashSet<string> Cities { get; private set; }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Area.GetHashCode();
        }

        public object Clone()
        {
            return new Country(this.Name, this.Population, this.Area, this.Cities.ToArray());
        }

        public int CompareTo(Country other)
        {
            var resultArea = this.Area.CompareTo(other.Area);

            if (resultArea == 0)
            {
                var resultPopulation = this.Population.CompareTo(other.Population);

                if (resultPopulation == 0)
                {
                    return String.Compare(this.Name, other.Name, StringComparison.InvariantCulture);
                }

                return resultPopulation * -1;
            }

            return resultArea * -1;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Country;

            if (other == null)
            {
                return false;
            }

            return this.Name == other.Name;
        }

        public static bool operator == (Country country1, Country country2)
        {
            if (object.Equals(country1,null))
            {
                return false;
            }

            return Country.Equals(country1, country2);   
        }

        public static bool operator != (Country country1, Country country2)
        {
            if (country1 == null || country2 == null)
            {
                return false;
            }

            return !(Country.Equals(country1, country2));
        }
    }
}
