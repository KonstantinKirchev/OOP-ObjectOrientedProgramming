namespace Problem2.Animals
{
    public class Kitten : Cat
    {
        private static int count = 0;
        private static int sum = 0;

        public Kitten(string name, int age, Gender gender = Gender.Female)
            : base(name, age, gender)
        {
            Kitten.count++;
            Kitten.sum += age;
        }

        public static double AverageAge
        {
            get { return (double)Kitten.sum / Kitten.count; }
        }
    }
}
