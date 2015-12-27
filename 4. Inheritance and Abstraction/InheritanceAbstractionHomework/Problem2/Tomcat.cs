namespace Problem2.Animals
{
    public class Tomcat : Cat
    {
        private static int count = 0;
        private static int sum = 0;

        public Tomcat(string name, int age, Gender gender = Gender.Male)
            : base(name, age, gender)
        {
            Tomcat.count++;
            Tomcat.sum += age;
        }

        public static double AverageAge
        {
            get { return (double)Tomcat.sum / Tomcat.count; }
        }
    }
}
