using System;

namespace Lab._07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsOfNums = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 0; i < rowsOfNums; i ++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
