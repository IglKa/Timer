﻿using System;
using ConsoleTimer;


namespace ConsoleTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many minutes to study? (integers only)");
            int MinsToStudy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your rest time? (integers only)");
            int MinsToRest = Convert.ToInt32(Console.ReadLine());

            var timer = new ConsoleTimer.Timer(MinsToStudy, MinsToRest);

            timer.Start();
        }
    }
}