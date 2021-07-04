using System;

namespace Ex._07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine()); // In seconds 
            double distance = double.Parse(Console.ReadLine()); // In meters 
            double timeInSeconds = double.Parse(Console.ReadLine()); // That he swims for 1 meter 
            double swimmerTime = distance * timeInSeconds; // Ivancho's time without the friction in seconds 
            double friction = Math.Floor(distance / 15); // friction * 12.5 The "times of delay" based on the swimmer's travelled distance 
            double delay = friction * 12.5; // The delay in seconds 
            double swimmerRecord = swimmerTime + delay; // Ivancho's time with the friction(delay) in seconds 
            
            if (friction >= 1)
            {
                if (worldRecord > swimmerRecord)
                {
                    Console.WriteLine($"Yes, he succeeded! The new world record is {swimmerRecord:f2} seconds.");
                }
                else
                {
                    Console.WriteLine($"No, he failed! He was {(swimmerRecord - worldRecord):f2} seconds slower.");
                }
            }
            else // there is no friction meaning distance is below 15 m 
            {
                if (worldRecord > swimmerRecord)
                {
                    Console.WriteLine($"Yes, he succeeded! The new world record is {swimmerRecord:f2} seconds.");
                }
                else
                {
                    Console.WriteLine($"No, he failed! He was {(swimmerRecord - worldRecord):f2} seconds slower.");
                }
            }
        }
    }
}
