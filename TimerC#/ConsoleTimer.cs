using Base;
using System;
using System.Threading.Tasks;


namespace ConsoleTimer
{
    class Timer : AbstractTimer, TimerI
    {
        private TimeSpan StudyTime;
        private TimeSpan RestTime;

        public Timer(int StudyTime, int RestTime)
            : base(new int[2] { StudyTime, RestTime }) // Passing times to a parent class constructor
        {
            this.StudyTime = new TimeSpan(00, StudyTime, 00);
            this.RestTime = new TimeSpan(00, RestTime, 00);
        }

        public void Start()
        {
            this.CountTime(this.StudyTime);
            this.CountTime(this.RestTime);
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public void SetTime(int StudyTime, int RestTime)
        {
            this.StudyTime = new TimeSpan(00, StudyTime, 00);
            this.RestTime = new TimeSpan(00, RestTime, 00);
        }

        public override void CountTime(TimeSpan Time) // Implemented method for ConsoleTimer
        {
            TimeSpan Zero = TimeSpan.Zero;
            TimeSpan ToSubstract = new TimeSpan(00, 00, 01);
            while (Time > Zero)
            {
                Console.WriteLine(Time);
                Time -= ToSubstract;
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
