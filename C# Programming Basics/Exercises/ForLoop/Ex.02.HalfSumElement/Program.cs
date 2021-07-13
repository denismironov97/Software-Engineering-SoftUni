using System;

namespace Ex._02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsOfNum = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue; // simple example -100
            int sum = 0;
            
            for (int i = 0; i < rowsOfNum; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum = sum + currentNum;
                if (currentNum > maxNum) // -100
                {
                    maxNum = currentNum;
                }
            }

            int sumWithoutMaxNum = sum - maxNum;
            
            if (sumWithoutMaxNum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumWithoutMaxNum - maxNum)}");
            }
        }
    }
}
