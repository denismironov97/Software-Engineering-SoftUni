using System;

namespace Lab._06.BuildingModV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFloors = int.Parse(Console.ReadLine());
            int numOfRooms = int.Parse(Console.ReadLine());
            int highestFloor = 0; //highest floor
            highestFloor = numOfFloors;
            int rooms = 0;

            while (numOfFloors > 0)
            {
                while (rooms < numOfRooms)
                {
                    if (highestFloor == numOfFloors)
                    {
                        Console.Write($"L{numOfFloors}{rooms} ");
                    }
                    else
                    {
                        if (numOfFloors % 2 == 0)
                        {
                            Console.Write($"O{numOfFloors}{rooms} ");
                        }
                        else
                        {
                            Console.Write($"A{numOfFloors}{rooms} ");
                        }
                    }

                    rooms++;
                }

                rooms = 0;
                numOfFloors--;
                Console.WriteLine();
            }
        }
    }
}
