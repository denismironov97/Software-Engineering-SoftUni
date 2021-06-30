using System;

namespace Lab._08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfTour = double.Parse(Console.ReadLine());
            int numOfPuzzles = int.Parse(Console.ReadLine());
            int numOfDolls = int.Parse(Console.ReadLine());
            int numOfToyBears = int.Parse(Console.ReadLine());
            int numOfMinions = int.Parse(Console.ReadLine());
            int numOfToyTrucks = int.Parse(Console.ReadLine());

            int totalNumOfOrders = numOfPuzzles + numOfDolls + numOfToyBears + numOfMinions + numOfToyTrucks;
            double priceOfOnePuzzle = 2.60;
            double priceOfOneDoll = 3;
            double priceOfOneToyBear = 4.10;
            double priceOfOneMinion = 8.20;
            double priceOfOneToyTruck = 2;
            double totalPriceOfTheWholeOrder = numOfPuzzles * priceOfOnePuzzle + numOfDolls * priceOfOneDoll + numOfToyBears * priceOfOneToyBear + numOfMinions * priceOfOneMinion + numOfToyTrucks * priceOfOneToyTruck;
            
            double rent = 0;
            double netPtofit = 0;
            double leftoverMoney = 0;

            if (totalNumOfOrders >= 50)
            {
                double incomeWithDiscount = totalPriceOfTheWholeOrder - totalPriceOfTheWholeOrder * 0.25;
                rent = incomeWithDiscount * 0.10;
                netPtofit = incomeWithDiscount - rent;
                
                if (netPtofit >= priceOfTour) //> =
                {
                    leftoverMoney = netPtofit - priceOfTour;
                    Console.WriteLine($"Yes! {leftoverMoney:f2} lv left.");
                }
                else
                {
                    leftoverMoney = Math.Abs(netPtofit - priceOfTour);
                    Console.WriteLine($"Not enough money! {leftoverMoney:f2} lv needed.");
                }
            }
            else // (totalNumOfOrders < 50)
            {
                rent = totalPriceOfTheWholeOrder * 0.10;
                netPtofit = totalPriceOfTheWholeOrder - rent;

                if (netPtofit >= priceOfTour) //>=
                {
                    leftoverMoney = netPtofit - priceOfTour;
                    Console.WriteLine($"Yes! {leftoverMoney:f2} lv left.");
                }
                else
                {
                    leftoverMoney = Math.Abs(netPtofit - priceOfTour);
                    Console.WriteLine($"Not enough money! {leftoverMoney:f2} lv needed.");
                }
            }
        }
    }
}
