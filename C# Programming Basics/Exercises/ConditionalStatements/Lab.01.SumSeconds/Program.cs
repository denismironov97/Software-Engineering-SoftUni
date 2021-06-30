using System;

namespace Lab._01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeOne = int.Parse(Console.ReadLine());
            int timeTwo = int.Parse(Console.ReadLine());
            int timeThree = int.Parse(Console.ReadLine());
            int totalTime = timeOne + timeTwo + timeThree;

            int minutes = totalTime / 60; // Will give total time in minutes, but only the whole, which what we need.
            int seconds = totalTime % 60; // Will give us the remainder of the devision. 

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
