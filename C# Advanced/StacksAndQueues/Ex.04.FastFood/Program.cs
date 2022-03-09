using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] ordersInputData = Console.ReadLine().Split(' ').Select(num => int.Parse(num)).ToArray();
            Queue<int> orders = new Queue<int>(ordersInputData);

            if (orders.Any())
            {
                Console.WriteLine(orders.Max());
            }

            if (quantityOfFood >= orders.Sum())
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                for (int i = 0; i < ordersInputData.Length; i++)
                {
                    quantityOfFood -= orders.Peek();

                    if (quantityOfFood >= 0)
                    {
                        orders.Dequeue();
                    }
                }

                Console.Write("Orders left: ");

                foreach (int order in orders)
                {
                    Console.Write($"{order} ");
                }
            }
        }
    }
}
