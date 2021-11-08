using System;
using System.Collections.Generic;

namespace Ex._01.C_tCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> countOfChars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }

                if (!countOfChars.ContainsKey(input[i]))
                {
                    countOfChars.Add(input[i], 1);
                }
                else
                {
                    countOfChars[input[i]]++;
                }
            }

            foreach (var keyValuePair in countOfChars)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}
