using System;

namespace Lab._06.BuildingModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFloors = int.Parse(Console.ReadLine());
            int numOfRooms = int.Parse(Console.ReadLine());

            for (int floor = numOfFloors; floor > 0; floor--)
            {
                for (int room = 0; room < numOfRooms; room++)
                {
                    if (floor == numOfFloors)
                    {
                        Console.Write($"L{floor}{room} ");
                    }

                    if (floor % 2 == 0 && !(floor == numOfFloors))
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else if (!(floor % 2 == 0) && !(floor == numOfFloors))
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
