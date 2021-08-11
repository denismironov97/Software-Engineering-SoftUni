using System;

namespace Ex._10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double priceOfHeadset = double.Parse(Console.ReadLine());
            double priceOfMouse = double.Parse(Console.ReadLine());
            double priceOfKeyboard = double.Parse(Console.ReadLine());
            double priceOfDisplay = double.Parse(Console.ReadLine());
            int countForTrashedHeadset = 0;
            int countForTrashedMouse = 0;
            int countForTrashedKeyboard = 0;
            int countForTrashedDisplay = 0;

            for (int currentLostGame = 1; currentLostGame <= lostGamesCount; currentLostGame++)
            {
                if (currentLostGame % 2 == 0)
                {
                    countForTrashedHeadset++;
                }
                if (currentLostGame % 3 == 0)
                {
                    countForTrashedMouse = countForTrashedMouse + 1;
                }
                if (currentLostGame % 6 == 0) //currentLostGame % 6 == 0 //currentLostGame % 2 == 0 && currentLostGame % 3 == 0
                {
                    countForTrashedKeyboard += 1;
                }
                if (currentLostGame % 12 == 0) //currentLostGame % 12 == 0 //currentLostGame % 2 == 0 && currentLostGame % 3 == 0 && countForTrashedKeyboard % 2 == 0
                {
                    countForTrashedDisplay++;
                }
            }

            double totalExpenses = priceOfHeadset * countForTrashedHeadset + priceOfMouse * countForTrashedMouse +
               +priceOfKeyboard * countForTrashedKeyboard + priceOfDisplay * countForTrashedDisplay;
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
