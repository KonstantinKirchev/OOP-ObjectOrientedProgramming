namespace Problem3.AsynchronousTimer
{
    using System;

    static class Program
    {
        static void Main()
        {          
            AsyncTimer timer = new AsyncTimer(10, 1000);
            timer.TimeChanged += Timer_TimeChanged;
            Console.WriteLine("Timer started for 10 ticks at interval 1000 ms.");
            timer.Run();
        }

        private static void Timer_TimeChanged(object sender,
        TimeChangedEventArgs eventArgs)
        {
            Console.WriteLine("Timer! Ticks left = {0}", eventArgs.TicksLeft);
        }
    }
}
