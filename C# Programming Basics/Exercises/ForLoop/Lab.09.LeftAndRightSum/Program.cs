using System;

namespace Lab._09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum = leftSum + number;
            }
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum += number; // rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                //No, diff = 1
                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}
