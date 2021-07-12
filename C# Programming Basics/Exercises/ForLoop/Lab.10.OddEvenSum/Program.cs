using System;

namespace Lab._10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsOfNumbers = int.Parse(Console.ReadLine());
            int sumEvenPosition = 0;
            int sumOddPosition = 0;

            for (int counter = 1; counter <= rowsOfNumbers; counter++)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (counter % 2 == 0) // even position
                {
                    sumEvenPosition += number;
                }
                else // odd position
                {
                    sumOddPosition += number;
                }
            }
            if (sumEvenPosition == sumOddPosition)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEvenPosition}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEvenPosition - sumOddPosition)}");
            }
        }
    }
}
