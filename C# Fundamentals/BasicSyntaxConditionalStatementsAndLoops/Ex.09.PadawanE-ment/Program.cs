using System;

namespace Ex._09.PadawanE_ment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyOnHand = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double priceOfSingleSaber = double.Parse(Console.ReadLine());
            double priceOfSingleRobe = double.Parse(Console.ReadLine());
            double priceOfSingleBelt = double.Parse(Console.ReadLine());

            double numOfNeededLightSabers = Math.Ceiling(numOfStudents * 1.1);
            int numFreeBelts = numOfStudents / 6; // the num of the free belts 
            double totalCost = numOfNeededLightSabers * priceOfSingleSaber + (priceOfSingleBelt * (numOfStudents - numFreeBelts)) + numOfStudents * priceOfSingleRobe;

            if (totalCost <= moneyOnHand)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalCost - moneyOnHand:f2}lv more.");
            }
        }
    }
}
