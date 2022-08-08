using System;
using System.Collections.Generic;

namespace Ex06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colorClothesOccurrence = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < nLines; i++)
            {
                string[] colorClothes = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries); //Gold -> dress,t - shirt,boxers
                string color = colorClothes[0];
                string[] clothes = colorClothes[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!colorClothesOccurrence.ContainsKey(color))
                {
                    colorClothesOccurrence.Add(color, new Dictionary<string, int>());
                }

                foreach (string clothing in clothes)
                {
                    if (!colorClothesOccurrence[color].ContainsKey(clothing))
                    {
                        colorClothesOccurrence[color].Add(clothing, 0);
                    }

                    colorClothesOccurrence[color][clothing]++;
                }
            }

            string[] colorClothSearch = Console.ReadLine().Split(" ");
            string colorSearch = colorClothSearch[0];
            string clothSearch = colorClothSearch[1];

            foreach (var kvpOfMainDict in colorClothesOccurrence)
            {
                string color = kvpOfMainDict.Key;
                Dictionary<string, int> clothesOccurence = kvpOfMainDict.Value;
                Console.WriteLine($"{color} clothes:");

                foreach (var kvpNestedDict in clothesOccurence)
                {
                    string clothing = kvpNestedDict.Key;
                    int occurenceCount = kvpNestedDict.Value;

                    if (color == colorSearch && clothing == clothSearch)
                    {
                        Console.WriteLine($"* {clothing} - {occurenceCount} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing} - {occurenceCount}");
                    }
                }
            }
        }
    }
}
