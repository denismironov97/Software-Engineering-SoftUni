using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._01.C_tChrInAStrngV01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> countOfChars = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (letter == ' ')
                {
                    continue;
                }

                if (!countOfChars.ContainsKey(letter))
                {
                    countOfChars.Add(letter, 1);
                }
                else
                {
                    countOfChars[letter]++;
                }
            }

            foreach (var keyValuePair in countOfChars)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}
