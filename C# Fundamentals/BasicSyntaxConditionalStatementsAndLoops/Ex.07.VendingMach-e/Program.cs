using System;

namespace Ex._07.VendingMach_e
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCoins = string.Empty;
            double sumOfInsertedCoins = 0;
            while ((inputCoins = Console.ReadLine()) != "Start")
            {
                double coinsInserted = double.Parse(inputCoins); // coins == 0.1, 0.2, 0.5, 1, and 2.00
                bool rightTypeCoins = coinsInserted == 0.1 || coinsInserted == 0.2 || coinsInserted == 0.5 || coinsInserted == 1 || coinsInserted == 2;
                if (rightTypeCoins)
                {
                    sumOfInsertedCoins += coinsInserted;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinsInserted}");
                }
            }

            double priceOfNuts = 2;
            double priceOfWater = 0.7;
            double priceOfCrisps = 1.5;
            double priceOfSoda = 0.8;
            double priceOfCoke = 1;
            string purchasedProduct = string.Empty; //"Nuts", "Water", "Crisps", "Soda", "Coke". 
            while ((purchasedProduct = Console.ReadLine()) != "End")
            {
                //bool enoughMoney = sumOfInsertedCoins >= priceOfWater;
                switch (purchasedProduct)
                {
                    case "Nuts":
                        sumOfInsertedCoins -= priceOfNuts;
                        if (sumOfInsertedCoins >= 0)
                        {
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumOfInsertedCoins += priceOfNuts;
                        }
                        break;
                    case "Water":
                        sumOfInsertedCoins -= priceOfWater;
                        if (sumOfInsertedCoins >= 0)
                        {
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumOfInsertedCoins += priceOfWater;
                        }
                        break;
                    case "Crisps":
                        sumOfInsertedCoins -= priceOfCrisps;
                        if (sumOfInsertedCoins >= 0)
                        {
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumOfInsertedCoins += priceOfCrisps;
                        }
                        break;
                    case "Soda":
                        sumOfInsertedCoins -= priceOfSoda;
                        if (sumOfInsertedCoins >= 0)
                        {
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumOfInsertedCoins += priceOfSoda;
                        }
                        break;
                    case "Coke":
                        sumOfInsertedCoins -= priceOfCoke;
                        if (sumOfInsertedCoins >= 0)
                        {
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            sumOfInsertedCoins += priceOfCoke;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }

            Console.WriteLine($"Change: {sumOfInsertedCoins:f2}");
        }
    }
}
