using System;

namespace Lab._01.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;

            while (hours <= 23)
            {
                while (minutes <= 59)
                {
                    Console.WriteLine($"{hours}:{minutes}");
                    minutes++;
                }

                minutes = 0;
                hours++;
            }
        }
    }
}
