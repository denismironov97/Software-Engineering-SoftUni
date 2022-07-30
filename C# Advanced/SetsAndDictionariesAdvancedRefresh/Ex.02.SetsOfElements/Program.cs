using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghtOfSet1AndSet2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < lenghtOfSet1AndSet2[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set1.Add(number);
            }

            for (int i = 0; i < lenghtOfSet1AndSet2[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set2.Add(number);
            }

            foreach (int numInSet1 in set1)
            {
                foreach (int numInSet2 in set2)
                {
                    if (numInSet1 == numInSet2)
                    {
                        Console.Write($"{numInSet1} ");
                    }
                }
            }
        }
    }
}
