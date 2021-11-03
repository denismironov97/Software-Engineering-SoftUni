using System;
using System.Linq;
using System.Collections.Generic;

namespace L._04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] sortedNums = nums.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < 3; i++)
            {
                if (sortedNums.Length < 3)
                {
                    Console.WriteLine(string.Join(" ", sortedNums));
                    break;
                }

                Console.Write($"{sortedNums[i]} ");
            }
        }
    }
}
