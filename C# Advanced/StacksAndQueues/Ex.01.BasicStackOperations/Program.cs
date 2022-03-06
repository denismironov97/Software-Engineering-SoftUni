using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elementsData = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int nPushElements = elementsData[0];//n times
            int sPopElements = elementsData[1];//s times 
            int xContainsElement = elementsData[2];
            int[] numsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < nPushElements; i++)
            {
                numbers.Push(numsInput[i]);
            }

            for (int i = 0; i < sPopElements; i++)
            {
                numbers.Pop();
            }

            bool containsNum = numbers.Contains(xContainsElement);

            if (containsNum)
            {
                Console.WriteLine(containsNum.ToString().ToLower());
            }
            else
            {
                //int minValue = int.MaxValue;

                //foreach (var number in numbers)
                //{
                //    if (number < minValue)
                //    {
                //        minValue = number;
                //    }
                //}

                //if (minValue == int.MaxValue)
                //{
                //    minValue = 0;
                //}

                //Console.WriteLine(minValue);

                int minValue = 0;

                if (numbers.Any())
                {
                    minValue = numbers.Min();
                    Console.WriteLine(minValue);
                }
                else
                {
                    Console.WriteLine(minValue);
                }
            }
        }
    }
}
