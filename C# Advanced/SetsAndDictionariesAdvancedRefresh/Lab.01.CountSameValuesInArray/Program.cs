using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Dictionary<double, int> numbersOccurrence = new Dictionary<double, int>();//key: number value occuranceOfTheNumber which is the key

            //foreach (int num in numbersInput)//ver01
            //{
            //    if (!numbersOccurrence.ContainsKey(num))
            //    {
            //        numbersOccurrence[num] = 0;
            //    }

            //    numbersOccurrence[num]++;
            //}

            foreach (int num in numbersInput)
            {
                if (!numbersOccurrence.ContainsKey(num))
                {
                    numbersOccurrence.Add(num, 1);
                }
                else
                {
                    numbersOccurrence[num]++;
                }
            }


            foreach (var kvp in numbersOccurrence)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
