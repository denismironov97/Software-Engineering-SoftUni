using System;

namespace Lab._09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double plotOfLand = double.Parse(Console.ReadLine());
            double priceOfOneSqrMLanscapedPlot = 7.61;
            double totalPriceOfLanscapedPlot = plotOfLand * priceOfOneSqrMLanscapedPlot; // total price without discount
            double discountPrice = totalPriceOfLanscapedPlot * 0.18; // the discount
            double discountedPriceOfLanscapedPlot = totalPriceOfLanscapedPlot - discountPrice; // final price with the discount
            Console.WriteLine($"The final price is: {discountedPriceOfLanscapedPlot} lv.");
            Console.WriteLine($"The discount is: {discountPrice} lv.");
        }
    }
}
