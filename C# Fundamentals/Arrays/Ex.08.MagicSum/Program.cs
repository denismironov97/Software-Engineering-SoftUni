using System;
using System.Linq;
namespace Ex._08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // [0] [1] [2] [3] [4] [5]
            //  1  7   6   2   19  23
            // 8

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == magicNum)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }

                }
            }
        }
    }
}
