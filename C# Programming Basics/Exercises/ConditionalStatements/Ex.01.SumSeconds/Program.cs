using System;

namespace Ex._01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totalSumOfSeconds = firstTime + secondTime + thirdTime;
            int minutes = totalSumOfSeconds / 60; // int is chosen on pupose  
            int seconds = totalSumOfSeconds % 60; // this will give you the seconds 
            // all would look like "minite : seconds";
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
