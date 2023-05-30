using System;
using System.Text;
using CountTime;

namespace Base
{
    abstract class AbstractTimer
    {
        const string FILE_NAME = "Timer.txt"; // File, where all values of time will be stored
        public ICountTimer Counter; // Strategy Pattern

        protected TimeSpan StudyTime;
        protected TimeSpan RestTime;

        public AbstractTimer(int[] times) 
        {
            Console.WriteLine($"You're values are: {times[0]} and {times[1]}"); // Will save times in FILE_NAME
        }

        public void SetCounter(ICountTimer Counter)
        {
            this.Counter = Counter;
        }

        public void StartTimer()
        {
            this.Counter.Count(this.StudyTime);
            this.Counter.Count(this.RestTime);
        }
    }
}
