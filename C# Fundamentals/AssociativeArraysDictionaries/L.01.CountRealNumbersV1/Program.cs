using System;
using System.Linq;
using System.Collections.Generic;

namespace L._01.CountRealNumbersV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            SortedDictionary<int, int> dictCountsOfOccurrences = new SortedDictionary<int, int>();

            foreach (int num in numbers)
            {
                if (dictCountsOfOccurrences.ContainsKey(num))
                {
                    dictCountsOfOccurrences[num]++;
                }
                else
                {
                    dictCountsOfOccurrences.Add(num, 1);
                }

                //if (!dictCountsOfOccurrences.ContainsKey(num))
                //{
                //    dictCountsOfOccurrences.Add(num, 1);
                //}
                //else
                //{
                //    dictCountsOfOccurrences[num]++;
                //}
            }

            foreach (var number in dictCountsOfOccurrences)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
