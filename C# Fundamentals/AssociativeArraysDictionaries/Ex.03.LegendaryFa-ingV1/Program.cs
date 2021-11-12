using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._03.LegendaryFa_ingV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            Dictionary<string, int> legendaryItemsData = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };

            string legendaryItem = string.Empty;
            bool isRunning = true;

            while (isRunning)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < inputData.Length; i += 2)
                {
                    int quantity = int.Parse(inputData[i]);
                    string item = inputData[i + 1].ToLower();

                    if (legendaryItemsData.ContainsKey(item))
                    {
                        legendaryItemsData[item] += quantity;

                        if (legendaryItemsData[item] >= 250)
                        {
                            legendaryItem = item;
                            legendaryItemsData[item] -= 250;
                            isRunning = false;
                            break;
                        }
                    }
                    else
                    {
                        if (junkItems.ContainsKey(item))
                        {
                            junkItems[item] += quantity;
                        }
                        else
                        {
                            junkItems.Add(item, quantity);
                        }
                    }
                }
            }

            if (legendaryItem == "shards")
            {
                Console.WriteLine($"Shadowmourne obtained!");
            }
            else if (legendaryItem == "fragments")
            {
                Console.WriteLine($"Valanyr obtained!");
            }
            else if (legendaryItem == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            Dictionary<string, int> soretedLegendaryItems = legendaryItemsData.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            Dictionary<string, int> sortedJunkIntems = junkItems.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in soretedLegendaryItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in sortedJunkIntems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
