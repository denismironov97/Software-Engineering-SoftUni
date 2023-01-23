using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex._04.FindEvensOrOddsV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int lowerBound = bounds[0];
            int upperBound = bounds[1];

            string command = Console.ReadLine();

            Predicate<int> filterPredicate;

            if (command == "even")
            {
                filterPredicate = x => x % 2 == 0;
            }
            else
            {
                filterPredicate = x => x % 2 != 0;
            }

            Func<int, int, Predicate<int>, List<int>> getEvenOrOddCollDelegate = GetCollectionOfNums;

            var resultCollection = getEvenOrOddCollDelegate(lowerBound, upperBound, filterPredicate);

            Console.WriteLine(string.Join(" ", resultCollection));
        }

        private static List<int> GetCollectionOfNums(int lowerBound, int upperBound, Predicate<int> predicateAr)
        {
            List<int> resultCollection = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (predicateAr(i))
                {
                    resultCollection.Add(i);
                }
            }

            return resultCollection;
        }
    }
}
