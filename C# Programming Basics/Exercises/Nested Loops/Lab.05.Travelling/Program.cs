using System;

namespace Lab._05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double totalSavings = 0;

                while (totalSavings < budget)
                {
                    double currentSavedMoney = double.Parse(Console.ReadLine());
                    totalSavings = totalSavings + currentSavedMoney;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
