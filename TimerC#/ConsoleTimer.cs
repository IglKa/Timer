using Base;
using System;
using System.Threading.Tasks;
using CountTime;


namespace Timer
{
    class ConsoleTimer : AbstractTimer
    {
        public ConsoleTimer(int StudyTime, int RestTime)
            : base(new int[2] { StudyTime, RestTime })
        {
            this.StudyTime = new TimeSpan(00, StudyTime, 00);
            this.RestTime = new TimeSpan(00, RestTime, 00);

            this.SetCounter(new CountTime.CountTimeFamily.CountConsole());
        }
    }
}
