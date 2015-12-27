using System;

namespace Problem2.FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            :this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807)
                {
                    throw new ArgumentOutOfRangeException("The numerator should be in the range [-9223372036854775808..9223372036854775807]");
                }
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807)
                {
                    throw new ArgumentOutOfRangeException("The denominator should be in the range [-9223372036854775808..9223372036854775807]");
                }
                else if (value == 0)
                {
                    throw new ArgumentException("The denominator cannot be 0.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long num = f1.Numerator*f2.Denominator + f1.Denominator*f2.Numerator;
            long denom = f1.Denominator*f2.Denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long num = f1.Numerator * f2.Denominator - f1.Denominator * f2.Numerator;
            long denom = f1.Denominator * f2.Denominator;
            return new Fraction(num, denom);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator/this.Denominator);
        }
    }
}
