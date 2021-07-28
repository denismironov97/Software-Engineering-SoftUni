using System;

namespace Ex._07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]
            //2.Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
            //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]

            //•	цената на малините е на половина по - ниска от тази на ягодите;
            //•	цената на портокалите е с 40 % по - ниска от цената на малините;
            //•	цената на бананите е с 80 % по - ниска от цената на малините.

            double priceOfStrawberries = double.Parse(Console.ReadLine());
            double quantityOfBananasInKg = double.Parse(Console.ReadLine());
            double quantityOfOrangesInKg = double.Parse(Console.ReadLine());
            double quantityOfBerries = double.Parse(Console.ReadLine());
            double quantityOfStrawberriesInKg = double.Parse(Console.ReadLine());
            double priceOfBerries = priceOfStrawberries * 0.50;
            double priceOfOranges = priceOfBerries * 0.60;
            double priceOfBananas = priceOfBerries * 0.20;
            double totalCost = priceOfStrawberries * quantityOfStrawberriesInKg + quantityOfBananasInKg * priceOfBananas + quantityOfOrangesInKg * priceOfOranges + quantityOfBerries * priceOfBerries;
            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
