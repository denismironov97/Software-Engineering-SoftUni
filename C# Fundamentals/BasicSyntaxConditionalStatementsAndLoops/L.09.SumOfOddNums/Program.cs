using System;

namespace L._09.SumOfOddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());
            int oddNum = 1;
            int sum = 0;
            for (int iterations = 1; iterations <= numRows; iterations++)
            {
                Console.WriteLine(oddNum);
                sum += oddNum;
                oddNum += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
