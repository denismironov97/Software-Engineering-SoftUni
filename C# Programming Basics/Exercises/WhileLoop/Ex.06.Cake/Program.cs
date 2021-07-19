using System;

namespace Ex._06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthOfCake = int.Parse(Console.ReadLine());
            int lenghtOfCake = int.Parse(Console.ReadLine());
            int totalCakeSlices = widthOfCake * lenghtOfCake;
            int totalTakenSlices = 0;
            int allCakeSlices = widthOfCake * lenghtOfCake;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }

                int currentTakenSlices = int.Parse(input);
                totalCakeSlices -= currentTakenSlices;
                totalTakenSlices += currentTakenSlices;

                if (totalCakeSlices <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {totalTakenSlices - allCakeSlices} pieces more.");
                    break;
                }
            }

            if (allCakeSlices > totalTakenSlices)
            {
                Console.WriteLine($"{allCakeSlices - totalTakenSlices} pieces are left.");
            }
        }
    }
}
