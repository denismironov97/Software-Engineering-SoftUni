using System;

namespace Lab._12.TradeCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            bool firstTab = sales >= 0 && sales <= 500;
            bool secondTab = sales > 500 && sales <= 1000;
            bool thirdTab = sales > 1000 && sales <= 10000;
            bool fouthTab = sales > 10000;
            
            if (town == "Sofia")
            {
                if (firstTab)
                {
                    Console.WriteLine($"{(sales * 0.05):f2}");
                }
                else if (secondTab)
                {
                    Console.WriteLine($"{(sales * 0.07):f2}");
                }
                else if (thirdTab)
                {
                    Console.WriteLine($"{(sales * 0.08):f2}");
                }
                else if (fouthTab)
                {
                    Console.WriteLine($"{(sales * 0.12):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (firstTab)
                {
                    Console.WriteLine($"{(sales * 0.045):f2}");
                }
                else if (secondTab)
                {
                    Console.WriteLine($"{(sales * 0.075):f2}");
                }
                else if (thirdTab)
                {
                    Console.WriteLine($"{(sales * 0.10):f2}");
                }
                else if (fouthTab)
                {
                    Console.WriteLine($"{(sales * 0.13):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (firstTab)
                {
                    Console.WriteLine($"{(sales * 0.055):f2}");
                }
                else if (secondTab)
                {
                    Console.WriteLine($"{(sales * 0.08):f2}");
                }
                else if (thirdTab)
                {
                    Console.WriteLine($"{(sales * 0.12):f2}");
                }
                else if (fouthTab)
                {
                    Console.WriteLine($"{(sales * 0.145):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
