namespace DefiningClasses
{
    class Program
    {
        static void Main()
        {
            var unnamed = new Dog();
            var sharo = new Dog("Sharo", "Melez");

            unnamed.Breed = "German Shepherd";

            unnamed.Bark();
            sharo.Bark();
        }
    }
}
