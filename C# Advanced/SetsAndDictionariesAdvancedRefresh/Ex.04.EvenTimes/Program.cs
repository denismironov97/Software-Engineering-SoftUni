using System;
using System.Collections.Generic;

namespace Ex._04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            Dictionary<int, int> numberCountOfOccurrence = new Dictionary<int, int>();

            for (int i = 0; i < nLines; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                if (!numberCountOfOccurrence.ContainsKey(currNumber))
                {
                    numberCountOfOccurrence.Add(currNumber, 1);
                }
                else
                {
                    numberCountOfOccurrence[currNumber]++;
                }
            }

            foreach (var kvp in numberCountOfOccurrence)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
