using System;
using System.Linq;
using System.Collections.Generic;

namespace L._01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            SortedDictionary<int, double> dictCountsOfOccurrences = new SortedDictionary<int, double>();

            foreach (int num in numbers)
            {
                //if (counts.ContainsKey(num))
                //{
                //    counts[num]++;
                //}
                //else
                //{
                //    counts.Add(num, 1);
                //}

                if (!dictCountsOfOccurrences.ContainsKey(num))
                {
                    dictCountsOfOccurrences.Add(num, 1);
                }
                else
                {
                    dictCountsOfOccurrences[num]++;
                }
            }

            foreach (var number in dictCountsOfOccurrences)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
