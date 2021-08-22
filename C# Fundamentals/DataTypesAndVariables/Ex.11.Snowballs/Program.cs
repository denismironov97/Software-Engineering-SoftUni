using System;
using System.Numerics;

namespace Ex._11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNSnowBalls = int.Parse(Console.ReadLine()); //range [0, 100]
            BigInteger maxSnowballValue = 0;
            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;

            for (int i = 0; i < numNSnowBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine()); //[0, 1000]
                int snowballTime = int.Parse(Console.ReadLine()); //[1, 500]
                int snowballQuality = int.Parse(Console.ReadLine()); //[0, 100]

                BigInteger currentSnowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality); // !

                if (currentSnowballValue > maxSnowballValue)
                {
                    maxSnowballValue = currentSnowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
        }
    }
}
