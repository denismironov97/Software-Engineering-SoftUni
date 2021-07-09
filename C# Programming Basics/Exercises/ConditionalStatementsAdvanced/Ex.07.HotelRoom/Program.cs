using System;

namespace Ex._07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine(); // May1, June1, July1, August1, September1 || October1
            int numOfNightsSpent = int.Parse(Console.ReadLine());
            double totalPriceOfApartment = 0;
            double totalPriceOfStudio = 0;
            
            if (month == "May" || month == "October")
            {
                totalPriceOfStudio = numOfNightsSpent * 50.00;
                totalPriceOfApartment = numOfNightsSpent * 65.00;
                
                if (numOfNightsSpent > 7 && numOfNightsSpent <= 14)
                {
                    totalPriceOfStudio = totalPriceOfStudio * 0.95;
                }
                else if (numOfNightsSpent > 14)
                {
                    totalPriceOfApartment = totalPriceOfApartment * 0.90;
                    totalPriceOfStudio = totalPriceOfStudio * 0.70;
                }
            }
            else if (month == "June" || month == "September")
            {
                totalPriceOfStudio = numOfNightsSpent * 75.20;
                totalPriceOfApartment = numOfNightsSpent * 68.70;
                
                if (numOfNightsSpent > 14)
                {
                    totalPriceOfApartment = totalPriceOfApartment * 0.90;
                    totalPriceOfStudio = totalPriceOfStudio * 0.80;
                }
            }
            else if (month == "July" || month == "August")
            {
                totalPriceOfStudio = numOfNightsSpent * 76.00;
                totalPriceOfApartment = numOfNightsSpent * 77.00;
                
                if (numOfNightsSpent > 14)
                {
                    totalPriceOfApartment = totalPriceOfApartment * 0.90;
                }
            }

            Console.WriteLine($"Apartment: {totalPriceOfApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceOfStudio:f2} lv.");
        }
    }
}
