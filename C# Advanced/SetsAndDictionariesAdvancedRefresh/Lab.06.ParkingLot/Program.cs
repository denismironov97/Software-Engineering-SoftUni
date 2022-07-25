using System;
using System.Collections.Generic;

namespace Lab._06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputDataParts = Console.ReadLine().Split(", ");
            HashSet<string> licenceNumbers = new HashSet<string>();

            while (inputDataParts[0] != "END")
            {
                string carLicenceNumber = inputDataParts[1];

                switch (inputDataParts[0])
                {
                    case "IN":
                        licenceNumbers.Add(carLicenceNumber);
                        break;
                    case "OUT":
                        licenceNumbers.Remove(carLicenceNumber);
                        break;
                }

                inputDataParts = Console.ReadLine().Split(", ");
            }

            if (licenceNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }

            foreach (string licenceNum in licenceNumbers)
            {
                Console.WriteLine(licenceNum);
            }
        }
    }
}
