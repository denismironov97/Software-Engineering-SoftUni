using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int nStations = int.Parse(Console.ReadLine());
            Queue<int[]> stationsDataCircle = new Queue<int[]>();
            FillQueue(nStations, stationsDataCircle);

            int totalFuel = 0;

            for (int i = 0; i < nStations; i++)
            {
                int[] stationData = stationsDataCircle.Dequeue();
                int fuel = stationData[0];
                int distance = stationData[1];
                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }

                stationsDataCircle.Enqueue(stationData);
            }

            Console.WriteLine(stationsDataCircle.Peek()[2]);
        }

        private static void FillQueue(int nStations, Queue<int[]> stationsDataCircle)
        {
            for (int i = 0; i < nStations; i++)
            {
                int indexPosOfStation = i;
                string petrolStationsInfo = Console.ReadLine();
                //petrolStationsInfo += $" {indexPosOfStation.ToString()}";
                petrolStationsInfo += $" {indexPosOfStation}";
                int[] petrolStationsData = petrolStationsInfo.Split(" ").Select(int.Parse).ToArray();
                stationsDataCircle.Enqueue(petrolStationsData);
            }
        }
    }
}
