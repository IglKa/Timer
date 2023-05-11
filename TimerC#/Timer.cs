using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace TimerC_
{
    class Timer
    {
        private string StudyTime;
        private string RestTime;

        public Timer(string TimeToStudy, string TimeToRest)
        {
            int MinutesStudy = Convert.ToInt32(TimeToStudy);
            int MinutesRest = Convert.ToInt32(TimeToRest);

            //if (this.Times.) // Get File
            //{
            //    this.StudyTime = new TimeSpan(00, MinutesStudy, 00).ToString();
            //    this.RestTime = new TimeSpan(00, MinutesRest, 00).ToString();
            //    this.Times = { this.StudyTime, this.RestTime };
            //} else
            //{
            //    this.StudyTime = this.Times[0];
            //    this.RestTime = this.Times[1];
            //}
            this.StudyTime = new TimeSpan(00, MinutesStudy, 00).ToString();
            this.RestTime = new TimeSpan(00, MinutesRest, 00).ToString();
        }

        private void CountTime(TimeSpan Time)
        {
            while (Time > TimeSpan.Zero)
            {
                Time -= new TimeSpan(00, 00, 01);
                Console.WriteLine(Time);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        public void Start()
        {
            this.CountTime(TimeSpan.Parse(this.StudyTime));
            this.CountTime(TimeSpan.Parse(this.RestTime));
        }

        
    }
}
