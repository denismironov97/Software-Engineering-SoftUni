using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._02.BasicQueueOperationsV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] infoData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int nElementsToEnqueue = infoData[0];
            int sElementsToDequeue = infoData[1];
            int xElementToLook = infoData[2];
            int[] numsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();

            foreach (int num in numsInput)
            {
                numbers.Enqueue(num);
            }

            for (int i = 0; i < sElementsToDequeue; i++)
            {
                numbers.Dequeue();
            }

            bool isValInQueuePresent = numbers.Contains(xElementToLook);

            if (isValInQueuePresent)
            {
                Console.WriteLine(isValInQueuePresent.ToString().ToLower());
            }
            else
            {
                if (numbers.Any())
                {
                    Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
