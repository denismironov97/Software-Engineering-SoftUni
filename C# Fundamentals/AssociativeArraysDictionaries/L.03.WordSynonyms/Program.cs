using System;
using System.Collections.Generic;

namespace L._03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictWordsAndSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < numOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dictWordsAndSynonyms.ContainsKey(word))
                {
                    dictWordsAndSynonyms[word] = new List<string>();
                }

                dictWordsAndSynonyms[word].Add(synonym);
            }

            foreach (var keyValuePair in dictWordsAndSynonyms)
            {
                Console.WriteLine($"{keyValuePair.Key} - {String.Join(", ", keyValuePair.Value)}");
            }
        }
    }
}
