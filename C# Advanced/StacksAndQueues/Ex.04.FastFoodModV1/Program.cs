using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._04.FastFoodModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantitiy = int.Parse(Console.ReadLine());
            int[] sequenceInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(sequenceInput);

            if (orders.Any())
            {
                Console.WriteLine(orders.Max());
            }

            int ordersCountConst = orders.Count;

            for (int i = 0; i < ordersCountConst; i++)//Can use the length of sequenceInput also
            {
                bool enoughtFoodQuantityLeft = foodQuantitiy - orders.Peek() >= 0;

                if (enoughtFoodQuantityLeft)
                {
                    foodQuantitiy -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
