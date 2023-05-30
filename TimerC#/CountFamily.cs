using System;


namespace CountTime
{
    interface ICountTimer
    {
        void Count(TimeSpan Time);
    }

    
    namespace CountTimeFamily 
    {
        class CountConsole : ICountTimer
        {
            public void Count(TimeSpan Time) 
            {
                TimeSpan ToSubstract = new TimeSpan(00, 00, 01);
                while (Time > TimeSpan.Zero)
                {
                    Console.WriteLine(Time);
                    Time -= ToSubstract;
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }

        class CountUI : ICountTimer
        {
            public void Count(TimeSpan Time) 
            {
                Console.WriteLine("Behaviour of CountUI");
            }
        }
    }
    
}