using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Queue<int> evenNumsQueue = new Queue<int>(numbersInput.Where(num => num % 2 == 0));
            //Console.WriteLine(string.Join(", ", evenNumsQueue));

            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Queue<int> queue = new Queue<int>(input);
            int count = queue.Sum();
            int sum = 0;

            while (sum != count) //Look up later 
            {
                sum += queue.Peek();

                if (queue.Peek() % 2 == 1)
                {
                    queue.Dequeue();
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
