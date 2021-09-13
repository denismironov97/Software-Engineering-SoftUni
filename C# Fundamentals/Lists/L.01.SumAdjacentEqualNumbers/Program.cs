using System;
using System.Collections.Generic;
using System.Linq;
namespace L._01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            GetResult(numbers);
        }
        static void GetResult(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (i + 1 > numbers.Count - 1)
                {
                    break;
                }
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
