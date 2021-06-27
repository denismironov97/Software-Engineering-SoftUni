using System;

namespace Ex._01.USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double currencyBgn = 1.79549;
            double bgn = usd * currencyBgn;
            Console.WriteLine(bgn);
        }
    }
}
