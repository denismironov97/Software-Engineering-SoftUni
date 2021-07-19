using System;

namespace Ex._04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goalOfSteps = 10000;
            string inputOfSteps = Console.ReadLine();
            int sumOfSteps = 0;
            int goingHomeSteps = 0;

            while (inputOfSteps != "Going home")
            {
                int currentIputOfSteps = int.Parse(inputOfSteps);
                sumOfSteps += currentIputOfSteps;

                if (sumOfSteps >= goalOfSteps)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{sumOfSteps - goalOfSteps} steps over the goal!");
                    break;
                }

                inputOfSteps = Console.ReadLine();
            }

            if (inputOfSteps == "Going home")
            {
                goingHomeSteps = int.Parse(Console.ReadLine());
                sumOfSteps += goingHomeSteps;

                if (sumOfSteps >= goalOfSteps)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{sumOfSteps - goalOfSteps} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{goalOfSteps - sumOfSteps} more steps to reach goal.");
                }
            }
        }
    }
}
