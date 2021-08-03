using System;

namespace L._04.BackIn30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalTimeAfter30InMins = hours * 60 + minutes + 30;
            
            if (totalTimeAfter30InMins / 60 >= 24) //24 hour format 
            {
                Console.WriteLine($"{totalTimeAfter30InMins / 60 % 24}:{totalTimeAfter30InMins % 60:d2}");
            }
            else
            {
                Console.WriteLine($"{totalTimeAfter30InMins / 60}:{totalTimeAfter30InMins % 60:d2}");
            }
        }
    }
}
