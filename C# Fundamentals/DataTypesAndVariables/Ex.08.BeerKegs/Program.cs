using System;

namespace Ex._08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKegs = int.Parse(Console.ReadLine());
            double maxVolumeBiggestKeg = 0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < numOfKegs; i++)
            {
                string modelKeg = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volumeOfCurrentKeg = (Math.PI * (Math.Pow(radius, 2))) * height;

                if (volumeOfCurrentKeg > maxVolumeBiggestKeg)
                {
                    maxVolumeBiggestKeg = volumeOfCurrentKeg;
                    biggestKeg = modelKeg;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
