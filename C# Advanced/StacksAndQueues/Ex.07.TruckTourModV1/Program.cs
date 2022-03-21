using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._07.TruckTourModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            FillQueue(nPumps, pumps);

            while (true)
            {
                int fuelAmount = 0;
                bool stationPumpPoint = true;// found a point after cycling through the pump stations

                for (int i = 0; i < nPumps; i++)//cycling through all the pump stations to find the point station
                {
                    int[] currPump = pumps.Dequeue();
                    fuelAmount += currPump[0];

                    if (fuelAmount < currPump[1])
                    {
                        stationPumpPoint = false;
                    }

                    fuelAmount -= currPump[1];
                    pumps.Enqueue(currPump);
                }

                if (stationPumpPoint)
                {
                    break;
                }

                pumps.Enqueue(pumps.Dequeue());//Преместваме първата помпа на последно място
            }

            int[] foundPumpStationInfo = pumps.Dequeue();
            Console.WriteLine(foundPumpStationInfo[2]);
        }

        private static void FillQueue(int nStations, Queue<int[]> pumps)
        {
            for (int i = 0; i < nStations; i++)
            {
                int indexPosOfPump = i;
                string petrolPumpsInfo = Console.ReadLine();
                //petrolPumpsInfo += $" {indexPosOfPump.ToString()}";
                petrolPumpsInfo += $" {indexPosOfPump}";
                int[] petrolStationsData = petrolPumpsInfo.Split(" ").Select(int.Parse).ToArray();
                pumps.Enqueue(petrolStationsData);
            }
        }
    }
}
