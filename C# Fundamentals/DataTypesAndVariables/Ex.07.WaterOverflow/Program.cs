using System;

namespace Ex._07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int totalLiters = 0;

            for (int i = 0; i < nLines; i++)
            {
                int includeLiters = int.Parse(Console.ReadLine());

                if (includeLiters + totalLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalLiters += includeLiters;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
