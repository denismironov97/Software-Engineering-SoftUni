using System;
using System.Collections.Generic;

namespace Ex._02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = string.Empty;
            Dictionary<string, int> resourseData = new Dictionary<string, int>();

            while ((inputData = Console.ReadLine()) != "stop")
            {
                string resource = inputData;
                int quantity = int.Parse(Console.ReadLine());

                if (resourseData.ContainsKey(resource))
                {
                    resourseData[resource] += quantity;
                }
                else
                {
                    resourseData.Add(resource, quantity);
                }
            }

            foreach (var kvp in resourseData)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
