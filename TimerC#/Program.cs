using TimerC_;


namespace ConsolTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many minutes to study? (integers only)");
            string MinsToStudy = Console.ReadLine();
            Console.WriteLine("What is your rest time? (integers only)");
            string MinsToRest = Console.ReadLine();

            var timer = new TimerC_.Timer(MinsToStudy, MinsToRest);

            timer.Start();
        }
    }
}