using System;

namespace Ex._04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFishers = int.Parse(Console.ReadLine());
            double rentForBoat = 0;
            bool discountOfSix = numOfFishers <= 6;
            bool discountUpToEleven = numOfFishers >= 7 && numOfFishers <= 11;
            bool discountForTweleveAndUp = numOfFishers >= 12;
            bool even = numOfFishers % 2 == 0;
            
            if (season == "Spring")
            {
                rentForBoat = 3000;
                if (even) // 5% discount on top everything else 
                {
                    if (discountOfSix)
                    {
                        rentForBoat = rentForBoat * 0.9;
                    }
                    else if (discountUpToEleven)
                    {
                        rentForBoat = rentForBoat * 0.85;
                    }
                    else if (discountForTweleveAndUp)
                    {
                        rentForBoat = rentForBoat * 0.75;
                    }
                    rentForBoat = rentForBoat * 0.95; // the (-5%) discount 
                }
                else
                {
                    if (discountOfSix)
                    {
                        rentForBoat = rentForBoat * 0.9;
                    }
                    else if (discountUpToEleven)
                    {
                        rentForBoat = rentForBoat * 0.85;
                    }
                    else if (discountForTweleveAndUp)
                    {
                        rentForBoat = rentForBoat * 0.75;
                    }
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rentForBoat = 4200;
                if (even) // 5% discount on top everything else 
                {
                    if (discountOfSix)
                    {
                        rentForBoat = rentForBoat * 0.9;
                    }
                    else if (discountUpToEleven)
                    {
                        rentForBoat = rentForBoat * 0.85;
                    }
                    else if (discountForTweleveAndUp)
                    {
                        rentForBoat = rentForBoat * 0.75;
                    }
                    if (season != "Autumn")
                    {
                        rentForBoat = rentForBoat * 0.95; // the (-5%) discount
                    }
                }
                else
                {
                    if (discountOfSix)
                    {
                        rentForBoat = rentForBoat * 0.9;
                    }
                    else if (discountUpToEleven)
                    {
                        rentForBoat = rentForBoat * 0.85;
                    }
                    else if (discountForTweleveAndUp)
                    {
                        rentForBoat = rentForBoat * 0.75;
                    }
                }
            }
            else if (season == "Winter")
            {
                rentForBoat = 2600;
                if (even) // 5% discount on top everything else 
                {
                    if (discountOfSix)
                    {
                        rentForBoat = rentForBoat * 0.9;
                    }
                    else if (discountUpToEleven)
                    {
                        rentForBoat = rentForBoat * 0.85;
                    }
                    else if (discountForTweleveAndUp)
                    {
                        rentForBoat = rentForBoat * 0.75;
                    }
                    rentForBoat = rentForBoat * 0.95; // the (-5%) discount 
                }
                else
                {
                    if (discountOfSix)
                    {
                        rentForBoat = rentForBoat * 0.9;
                    }
                    else if (discountUpToEleven)
                    {
                        rentForBoat = rentForBoat * 0.85;
                    }
                    else if (discountForTweleveAndUp)
                    {
                        rentForBoat = rentForBoat * 0.75;
                    }
                }
            }
            if (budget >= rentForBoat)
            {
                Console.WriteLine($"Yes! You have {(budget - rentForBoat):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(Math.Abs(budget - rentForBoat)):f2} leva.");
            }
        }
    }
}
