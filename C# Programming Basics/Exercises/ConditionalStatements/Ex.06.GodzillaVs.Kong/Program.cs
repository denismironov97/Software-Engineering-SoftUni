using System;

namespace Ex._06.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetForMovie = double.Parse(Console.ReadLine());
            int numOfStatists = int.Parse(Console.ReadLine());
            double priceOfClothingForOneStatist = double.Parse(Console.ReadLine());
            double decor = budgetForMovie * 0.1;
            double totalPriceOfClothing = numOfStatists * priceOfClothingForOneStatist;
            bool checkIfEnoughtMoney = totalPriceOfClothing + decor > budgetForMovie;
            
            if (numOfStatists > 150)
            {
                totalPriceOfClothing = totalPriceOfClothing * 0.9;
            }

            if (checkIfEnoughtMoney)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {((totalPriceOfClothing + decor) - budgetForMovie):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budgetForMovie - (totalPriceOfClothing + decor)):f2} leva left.");
            }
        }
    }
}
