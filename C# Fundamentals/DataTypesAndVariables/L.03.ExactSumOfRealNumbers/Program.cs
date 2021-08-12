using System;

namespace L._03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            decimal sumOfNum = 0M;
            for (int i = 0; i < numOfRows; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                sumOfNum += currentNum;
            }
            Console.WriteLine(sumOfNum);
        }
    }
}
