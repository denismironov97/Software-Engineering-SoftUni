using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._03.MaximumAndMinimumElementV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < nLines; i++)
            {
                int[] dataCommandInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                switch (dataCommandInfo[0])
                {
                    case 1:
                        numbers.Push(dataCommandInfo[1]);
                        break;
                    case 2:
                        if (numbers.Any())
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:
                        if (numbers.Any())
                        {
                            Console.WriteLine($"{numbers.Max()}");
                        }
                        break;
                    case 4:
                        if (numbers.Any())
                        {
                            Console.WriteLine($"{numbers.Min()}");
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
