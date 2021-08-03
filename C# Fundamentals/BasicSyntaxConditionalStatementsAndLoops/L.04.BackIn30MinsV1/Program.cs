using System;

namespace L._04.BackIn30MinsV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalTimeInMinutes = hours * 60 + minutes + 30; // total time after 30 mins in mins 
            int twentyFourHourFormat = totalTimeInMinutes / 60 % 24;
            if (totalTimeInMinutes / 60 >= 24) // 24 hour format
            {
                if (totalTimeInMinutes % 60 >= 10)
                {
                    Console.WriteLine($"{twentyFourHourFormat}:{totalTimeInMinutes % 60}");
                }
                else if (totalTimeInMinutes % 60 < 10)
                {
                    Console.WriteLine($"{twentyFourHourFormat}:0{totalTimeInMinutes % 60}");
                }
            }
            else
            {
                if (totalTimeInMinutes % 60 >= 10)
                {
                    Console.WriteLine($"{totalTimeInMinutes / 60}:{totalTimeInMinutes % 60}");
                }
                else if (totalTimeInMinutes % 60 < 10)
                {
                    Console.WriteLine($"{totalTimeInMinutes / 60}:0{totalTimeInMinutes % 60}");
                }
            }
        }
    }
}
