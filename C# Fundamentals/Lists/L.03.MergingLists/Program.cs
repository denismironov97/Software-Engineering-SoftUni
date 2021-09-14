using System;
using System.Linq;
using System.Collections.Generic;

namespace L._03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listNums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = GetMergingLists(listNums1, listNums2);
            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> GetMergingLists(List<int> listNums1C, List<int> listNums2C)
        {
            // 3   5   2   43   12   3   54   10   23
            // 76  5   34  2    4    12

            List<int> mergedList = new List<int>();
            for (int i = 0; i < Math.Min(listNums1C.Count, listNums2C.Count); i++)
            {
                mergedList.Add(listNums1C[i]);
                mergedList.Add(listNums2C[i]);
            }
            if (listNums1C.Count > listNums2C.Count)
            {
                mergedList.AddRange(GetRemainingElements(listNums1C, listNums2C));
                return mergedList;
            }
            else
            {
                mergedList.AddRange(GetRemainingElements(listNums2C, listNums1C));
                return mergedList;
            }
        }

        static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList) // 
        {
            List<int> nums = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                nums.Add(longerList[i]);
            }
            return nums;
        }
    }
}
