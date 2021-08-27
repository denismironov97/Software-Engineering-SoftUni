using System;
using System.Linq;
namespace L._07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrString1 = Console.ReadLine().Split();
            int[] array1 = new int[arrString1.Length];
            for (int i = 0; i < arrString1.Length; i++)
            {
                array1[i] = int.Parse(arrString1[i]);
            }

            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    Environment.Exit(0);
                }
                else
                {
                    sum += array1[i];
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
