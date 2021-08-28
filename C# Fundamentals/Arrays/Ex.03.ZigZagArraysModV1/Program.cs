using System;
using System.Linq;
namespace Ex._03.ZigZagArraysModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int[] array1 = new int[nLines];
            int[] array2 = new int[nLines];

            for (int i = 0; i < nLines; i++)
            {
                int[] currentLineOfSetNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 0) // even row
                {
                    array1[i] = currentLineOfSetNums[0];
                    array2[i] = currentLineOfSetNums[1];
                }
                else // odd row
                {
                    array1[i] = currentLineOfSetNums[1];
                    array2[i] = currentLineOfSetNums[0];
                }
            }

            Console.WriteLine(string.Join(' ', array1));
            Console.WriteLine(string.Join(' ', array2));
        }
    }
}
