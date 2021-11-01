using System;
using System.Linq;
using System.Collections.Generic;

namespace L._02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            Dictionary<string, int> countsOfOccurences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string tempWordInLowerCase = word.ToLower();

                if (countsOfOccurences.ContainsKey(tempWordInLowerCase))
                {
                    countsOfOccurences[tempWordInLowerCase]++;
                }
                else
                {
                    countsOfOccurences.Add(tempWordInLowerCase, 1);
                }
            }

            foreach (var keyValuePair in countsOfOccurences)
            {
                if (keyValuePair.Value % 2 != 0) // odd value 
                {
                    Console.Write(keyValuePair.Key + " ");
                }
            }
        }
    }
}
