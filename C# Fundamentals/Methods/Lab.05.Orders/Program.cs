using System;

namespace Lab._05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string beverage = Console.ReadLine(); //water, coffee, coke, snacks 
            int quantity = int.Parse(Console.ReadLine());
            PrintPriceOrder(beverage, quantity);
        }
        static void PrintPriceOrder(string beverage, int quantity)
        {
            double priceOfProduct = 0;
            if (beverage == "coffee")
            {
                priceOfProduct = 1.50;
            }
            else if (beverage == "water")
            {
                priceOfProduct = 1;
            }
            else if (beverage == "coke")
            {
                priceOfProduct = 1.40;
            }
            else//snacks
            {
                priceOfProduct = 2;
            }
            double totalPrice = priceOfProduct * quantity;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
