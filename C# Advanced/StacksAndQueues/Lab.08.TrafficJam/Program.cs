using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCarsCanPassAtGivenTime = int.Parse(Console.ReadLine());
            string carModel = Console.ReadLine();
            Queue<string> carsInTheQueue = new Queue<string>();
            ushort countCarsPassed = 0;

            while (carModel != "end")
            {
                if (carModel == "green")
                {
                    for (int i = 0; i < nCarsCanPassAtGivenTime; i++)
                    {
                        if (carsInTheQueue.Any())
                        {
                            Console.WriteLine($"{carsInTheQueue.Dequeue()} passed!");
                            countCarsPassed++;
                        }
                    }
                }
                else
                {
                    carsInTheQueue.Enqueue(carModel);
                }

                carModel = Console.ReadLine();
            }

            Console.WriteLine($"{countCarsPassed} cars passed the crossroads.");
        }
    }
}
