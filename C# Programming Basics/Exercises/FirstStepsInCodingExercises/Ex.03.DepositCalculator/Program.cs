using System;

namespace Ex._03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int durrationOfDeposit = int.Parse(Console.ReadLine()); // durration in months 
            double yearlyInterestRate = double.Parse(Console.ReadLine()); // divided by 100 
            double endSum = depositSum + durrationOfDeposit * ((depositSum * (yearlyInterestRate / 100)) / 12);
            Console.WriteLine(endSum);
        }
    }
}
