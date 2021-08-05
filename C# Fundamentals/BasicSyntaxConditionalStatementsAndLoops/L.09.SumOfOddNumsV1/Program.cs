using System;

namespace L._09.SumOfOddNumsV1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numRows = int.Parse(Console.ReadLine());
            var sumOfOddNumbers = 0;
            for (var number = 1; number <= numRows; number++)
            {
                Console.WriteLine("{0}", number * 2 - 1);
                sumOfOddNumbers = sumOfOddNumbers + 2 * number - 1;
            }
            Console.WriteLine("Sum: {0}", sumOfOddNumbers);
        }
    }
}
