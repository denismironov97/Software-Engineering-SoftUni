using System;

namespace Ex._03.SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            string typeString = "";

            if (speed <= 10)
            {
                typeString = "slow";
            }
            else if (speed <= 50)
            {
                typeString = "average";
            }
            else if (speed <= 150)
            {
                typeString = "fast";
            }
            else if (speed <= 1000)
            {
                typeString = "ultra fast";
            }
            else
            {
                typeString = "extremely fast";
            }

            Console.WriteLine(typeString);
        }
    }
}
