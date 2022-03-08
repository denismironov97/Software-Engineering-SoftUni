using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int nQueryes = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < nQueryes; i++)
            {
                int[] dataQuery = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (dataQuery[0])
                {
                    case 1:
                        numbers.Push(dataQuery[1]);
                        break;
                    case 2:
                        //if (numbers.Any()) // checks if there is at least 1 element in the stack, stack count is >= 1 == numbers.Count > 0
                        //{
                        //    numbers.Pop();
                        //}

                        if (!CheckIfStackIsEmpty(numbers.Count))
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:

                        if (!CheckIfStackIsEmpty(numbers.Count))
                        {
                            int maxValueInStack = numbers.Max();
                            Console.WriteLine(maxValueInStack);
                        }
                        break;
                    case 4:

                        if (!CheckIfStackIsEmpty(numbers.Count))
                        {
                            int minValueInStack = numbers.Min();
                            Console.WriteLine(minValueInStack);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static bool CheckIfStackIsEmpty(int countOfElementsInStack)
        {
            if (countOfElementsInStack > 0)
            {
                return false;
            }

            return true;
        }
    }
}
