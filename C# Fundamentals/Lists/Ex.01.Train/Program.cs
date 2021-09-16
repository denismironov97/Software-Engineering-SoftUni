using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersWagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int passengersLimit = int.Parse(Console.ReadLine());
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                int peopleToAdd = 0;
                string[] currentCommand = input.Split();
                if (currentCommand[0] == "Add")
                {
                    peopleToAdd = int.Parse(currentCommand[1]);
                    passengersWagons.Add(peopleToAdd);
                }
                else // If(currentCommand[0] != "Add")
                {
                    peopleToAdd = int.Parse(currentCommand[0]);
                    for (int i = 0; i < passengersWagons.Count; i++)
                    {
                        if ((passengersWagons[i] + peopleToAdd) <= passengersLimit)
                        {
                            passengersWagons[i] += peopleToAdd;
                            break;
                        }
                    }

                }
            }
            foreach (int numPeople in passengersWagons)
            {
                Console.Write($"{numPeople} ");
            }
        }
    }
}
