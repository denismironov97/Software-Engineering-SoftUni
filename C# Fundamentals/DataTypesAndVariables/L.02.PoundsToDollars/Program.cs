using System;

namespace L._02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 British Pound = 1.31 Dollars
            decimal britishPounds = decimal.Parse(Console.ReadLine());
            decimal dollars = britishPounds * 1.31M;
            Console.WriteLine("{0:f3}", dollars);
        }
    }
}
