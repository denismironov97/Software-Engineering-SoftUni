using System;

namespace Ex._06.CakeModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthOfCake = int.Parse(Console.ReadLine());
            int lenghtOfCake = int.Parse(Console.ReadLine());
            int allPicesOfCake = widthOfCake * lenghtOfCake; //
            int totalTakenSlices = 0; //
            int totalCakeSlicesLeft = widthOfCake * lenghtOfCake;
            string takenPices = "";

            while ((takenPices = Console.ReadLine()) != "STOP")
            {
                int currentTakenPices = int.Parse(takenPices);
                totalCakeSlicesLeft -= currentTakenPices;// деинкрементираме
                totalTakenSlices += currentTakenPices;

                if (totalCakeSlicesLeft <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {totalTakenSlices - allPicesOfCake} pieces more.");
                    break;
                }
            }

            if (allPicesOfCake > totalTakenSlices)
            {
                Console.WriteLine($"{allPicesOfCake - totalTakenSlices} pieces are left.");
            }
        }
    }
}
