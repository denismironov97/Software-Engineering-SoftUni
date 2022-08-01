using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            Dictionary<char, int> symbolCountOfOccurrence = new Dictionary<char, int>();

            foreach (char symbol in text)
            {
                if (!symbolCountOfOccurrence.ContainsKey(symbol))
                {
                    symbolCountOfOccurrence.Add(symbol, 0);
                }

                symbolCountOfOccurrence[symbol]++;
            }

            symbolCountOfOccurrence = symbolCountOfOccurrence.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in symbolCountOfOccurrence)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
