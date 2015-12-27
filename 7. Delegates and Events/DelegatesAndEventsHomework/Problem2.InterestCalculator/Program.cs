namespace Problem2.InterestCalculator
{
    static class Program
    {
        static void Main()
        {
            new InterestCalculator(500, 5.6, 10, "compound");
            new InterestCalculator(2500, 7.2, 15, "simple");
        }
    }
}
