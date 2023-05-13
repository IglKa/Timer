using System;
using System.Text;


namespace Base
{
    interface TimerI
    {
        void Start();
        void Stop();
        void SetTime(int StudyTime, int RestTime);
    }

    abstract class AbstractTimer
    {
        const string FILE_NAME = "Timer.txt"; // File, where all values of time will be stored

        public AbstractTimer(int[] times) 
        {
            Console.WriteLine($"You're values are: {times[0]} and {times[1]}"); // Will save times in FILE_NAME
        }

        public virtual void CountTime(TimeSpan Time) {} // Must be implemented by child
    }

}
