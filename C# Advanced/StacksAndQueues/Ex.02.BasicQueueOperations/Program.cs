using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] elementsData = new int[input.Length];

            for (int i = 0; i < elementsData.Length; i++)
            {
                elementsData[i] = int.Parse(input[i]);
            }

            int nEnqueueElements = elementsData[0];//n times
            int sDequeueElements = elementsData[1];//s times 
            int xContainsElement = elementsData[2];
            int[] numsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < nEnqueueElements; i++)
            {
                queue.Enqueue(numsInput[i]);
            }

            for (int i = 0; i < sDequeueElements; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(xContainsElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minVal = int.MaxValue;

                foreach (int number in queue)
                {
                    if (number < minVal)
                    {
                        minVal = number;
                    }
                }

                if (minVal == int.MaxValue)
                {
                    minVal = 0;
                }

                Console.WriteLine(minVal);
            }
        }
    }
}
