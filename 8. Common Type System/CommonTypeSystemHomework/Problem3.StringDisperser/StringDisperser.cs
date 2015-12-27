namespace Problem3.StringDisperser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        public StringDisperser(params string[] names)
        {
            this.Names = new List<string>(names);
        }

        public IList<string> Names { get; private set; }

        public IEnumerator GetEnumerator()
        {
            string disperserAsString = this.ToString();

            for (var i = 0; i < disperserAsString.Length; i++)
            {
                yield return disperserAsString[i];
            }
        }

        public object Clone()
        {
            return new StringDisperser(this.Names.ToArray());
        }

        public int CompareTo(StringDisperser other)
        {
            return String.Compare(this.ToString(), other.ToString(), StringComparison.InvariantCulture);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as StringDisperser;

            if (other == null)
            {
                return false;
            }

            return this.ToString().Equals(other.ToString());
        }

        public static bool operator ==(StringDisperser sd1, StringDisperser sd2)
        {
            if (object.Equals(sd1, null) || object.Equals(sd2, null))
            {
                return false;
            }

            return StringDisperser.Equals(sd1, sd2);
        }

        public static bool operator !=(StringDisperser sd1, StringDisperser sd2)
        {
            if (sd1 == null || sd2 == null)
            {
                return false;
            }

            return !StringDisperser.Equals(sd1, sd2);
        }

        public override string ToString()
        {
            return string.Join(string.Empty,this.Names);
        }
    }
}
