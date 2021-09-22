using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 2 3 |4 5 6 |  7  8
            // List<int> numbersInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            // var input = Console.ReadLine().Split('|', ' ').ToList();

            //List<int> input = Console.ReadLine()
            //    .Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            List<string> input = Console.ReadLine().Split('|').ToList();
            for (int i = 0; i < input.Count / 2; i++) // reversing places array algorithm // important
            {
                var oldElement = input[i];
                input[i] = input[input.Count - 1 - i];
                input[input.Count - 1 - i] = oldElement;
            }
            // or input.Reverse;
            List<int> numbers = new List<int>();
            foreach (string str in input) //important
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                     );
            }
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
