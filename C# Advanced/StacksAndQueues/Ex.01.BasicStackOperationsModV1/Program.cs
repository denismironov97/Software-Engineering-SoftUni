using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._01.BasicStackOperationsModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] infoData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int nElementsToStack = infoData[0];
            int sElementsToPop = infoData[1];
            int xElementToLook = infoData[2];

            int[] numsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //Stack<int> stack = new Stack<int>(numsInput);
            Stack<int> stack = new Stack<int>();

            foreach (int num in numsInput)
            {
                stack.Push(num);
            }

            for (int i = 0; i < sElementsToPop; i++)
            {
                stack.Pop();
            }

            bool isValueInStack = stack.Contains(xElementToLook);

            if (isValueInStack)
            {
                Console.WriteLine(isValueInStack.ToString().ToLower());
            }
            else
            {
                //1
                //int minVal = int.MaxValue;

                //foreach (int num in stack)
                //{
                //    if (num < minVal)
                //    {
                //        minVal = num;
                //    }
                //}

                //if (minVal == int.MaxValue)
                //{
                //    minVal = 0;
                //}

                //Console.WriteLine(minVal);

                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
