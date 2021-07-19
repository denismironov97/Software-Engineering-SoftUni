using System;

namespace Ex._03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            int counterForDays = 0; // = daysOfSpending + daysOfSaving;
            int counterForSpending = 0;
            
            while (moneyOnHand < moneyForVacation && counterForSpending < 5)
            {
                string saveOrSpend = Console.ReadLine();
                double savedOrSpentMoney = double.Parse(Console.ReadLine());
                counterForDays++;
                
                if (saveOrSpend == "save")
                {
                    moneyOnHand = moneyOnHand + savedOrSpentMoney;
                    counterForSpending = 0;
                }
                else // spend 
                {
                    if (moneyOnHand - savedOrSpentMoney < 0)
                    {
                        moneyOnHand = 0;
                    }
                    else
                    {
                        moneyOnHand -= savedOrSpentMoney;
                    }

                    counterForSpending++;
                }
            }

            if (counterForSpending == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(counterForDays);
            }

            if (moneyOnHand >= moneyForVacation)
            {
                Console.WriteLine($"You saved the money for {counterForDays} days.");
            }
        }
    }
}
