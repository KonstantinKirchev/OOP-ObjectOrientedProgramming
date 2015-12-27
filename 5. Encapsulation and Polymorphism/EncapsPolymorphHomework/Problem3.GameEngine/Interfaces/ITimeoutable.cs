namespace Problem3.GameEngine.Interfaces
{
    public interface ITimeoutable
    {
        int Timeout { get; set; }

        int Countdown { get; set; }

        bool HasTimedOut { get; set; }
    }
}
