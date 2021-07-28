using System;

namespace Ex._06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Броят на дните, в които тече кампанията – цяло число в интервала[0 … 365]
            //2.Броят на сладкарите – цяло число в интервала[0 … 1000]
            //3.Броят на тортите – цяло число в интервала[0… 2000]
            //4.Броят на гофретите – цяло число в интервала[0 … 2000]
            //5.Броят на палачинките – цяло число в интервала[0 … 2000]
            //•	Торта - 45 лв.
            //•	Гофрета - 5.80 лв.
            //•	Палачинка – 3.20 лв.

            int days = int.Parse(Console.ReadLine());
            int numOfSweets = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfWaffles = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());
            double priceOfCake = 45.00;
            double priceOfWaffle = 5.80;
            double priceOfPancake = 3.20;
            double totalRevenue = days * (numOfSweets * (numOfCakes * priceOfCake + numOfWaffles * priceOfWaffle + numOfPancakes * priceOfPancake));
            double totalCost = totalRevenue / 8;
            double netProfit = totalRevenue - totalCost;
            Console.WriteLine(netProfit);
        }
    }
}
