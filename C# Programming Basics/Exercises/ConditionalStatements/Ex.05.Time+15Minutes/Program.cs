using System;

namespace Ex._05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int fifteenMinutes = 15;
            int hoursInMinsPlusFifteenMins = hour * 60 + minutes + fifteenMinutes;
            int trueHours = hoursInMinsPlusFifteenMins / 60;
            int trueMins = hoursInMinsPlusFifteenMins % 60;
            int twentyfourHourFormat = trueHours % 24;
            
            if (trueHours < 24)
            {
                if (trueMins < 10)
                {
                    Console.WriteLine($"{trueHours}:0{trueMins}");
                }
                else
                {
                    Console.WriteLine($"{trueHours}:{trueMins}");
                }
            }
            else
            {
                if (trueMins < 10)
                {
                    Console.WriteLine($"{twentyfourHourFormat}:0{trueMins}");
                }
                else
                {
                    Console.WriteLine($"{twentyfourHourFormat}:{trueMins}");
                }
            }
        }
    }
}
