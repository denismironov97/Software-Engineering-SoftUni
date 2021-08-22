using System;
using System.Numerics;
namespace Ex._11.SnowballsModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNSnowBalls = int.Parse(Console.ReadLine()); //range [0, 100]
            BigInteger maxSnowballValue = 0;

            string result = string.Empty;

            for (int i = 0; i < numNSnowBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine()); //[0, 1000]
                int snowballTime = int.Parse(Console.ReadLine()); //[1, 500]
                int snowballQuality = int.Parse(Console.ReadLine()); //[0, 100]

                BigInteger currentSnowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality); // !

                if (currentSnowballValue > maxSnowballValue)
                {
                    maxSnowballValue = currentSnowballValue;
                    result = $"{snowballSnow} : {snowballTime} = {maxSnowballValue} ({snowballQuality})";
                }
            }

            Console.WriteLine(result);
        }
    }
}
