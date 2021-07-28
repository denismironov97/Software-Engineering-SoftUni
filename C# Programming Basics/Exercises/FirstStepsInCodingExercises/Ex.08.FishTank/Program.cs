using System;

namespace Ex._08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine()); // in cm 
            int width = int.Parse(Console.ReadLine()); // in cm
            int height = int.Parse(Console.ReadLine()); // in cm 
            double percentageFromConsole = double.Parse(Console.ReadLine());
            double truePercentage = percentageFromConsole * 0.01; // turning it into percantage // alternative = percentageFromConsole / 100;     
            int volumeOfWholeFishTank = lenght * width * height; // in cm3
            double volumeOfFishTankJustWater = volumeOfWholeFishTank * (1 - truePercentage);
            //double volumeOfFishTankJustWater = volumeOfWholeFishTank - volumeOfWholeFishTank * truePercentage; // in cm3
            double volumeOfWaterInfishTankInLiters = volumeOfFishTankJustWater * 0.001; // laternative = volulmeOfFishTankJustWater / 1000; 
            Console.WriteLine(volumeOfWaterInfishTankInLiters);
        }
    }
}
