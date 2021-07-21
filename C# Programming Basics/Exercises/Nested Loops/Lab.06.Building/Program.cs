using System;

namespace Lab._06.Building
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
                    else
                    {
                        if (floor % 2 == 0) // office 
                        {
                            Console.Write($"O{floor}{room} ");
                        }
                        else // aprtment 
                        {
                            Console.Write($"A{floor}{room} ");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
