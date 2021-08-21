using System;

namespace Ex._09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine()); // 111
            int days = 0;
            int totalSpiceExtracted = 0;

            while (startingYield >= 100)
            {
                int extractedSpice = startingYield; // 111 day 1; 101 day 2
                extractedSpice -= 26; // 85; 75;
                totalSpiceExtracted += extractedSpice; // 85; 160;
                days++;
                startingYield -= 10;
            }

            totalSpiceExtracted -= 26;

            if (totalSpiceExtracted < 0)
            {
                totalSpiceExtracted = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalSpiceExtracted);
        }
    }
}
