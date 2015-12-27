namespace Problem2.InterestCalculator
{
    using System;

    public delegate void CalculateInterest(double sum, double interest, int years);

    public class InterestCalculator
    {
        private const int N = 12;

        private string type;

        public InterestCalculator(double money, double interest, int years, string type)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.Type = type;
        }

        public double Money { get; set; }

        public double Interest { get; set; }

        public int Years { get; set; }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (value == "compound")
                {
                    var result = new CalculateInterest(GetCompoundInterest);
                    result(this.Money, this.Interest, this.Years);
                }

                else if (value == "simple")
                {
                    var result = new CalculateInterest(GetSimpleInterest);
                    result(this.Money, this.Interest, this.Years);
                }

            }
        }

        static void GetSimpleInterest(double sum, double interest, int years)
        {
            var result = sum * (1 + (interest / 100) * years);
            Console.WriteLine("{0:F4}", result);
        }

        static void GetCompoundInterest(double sum, double interest, int years)
        {
            var power = years * N;
            var result = sum * Math.Pow((1 + ((interest / 100) / N)), power);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
