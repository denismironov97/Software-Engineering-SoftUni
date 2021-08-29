using System;

namespace Ex._04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputVals = Console.ReadLine().Split();
            int[] arrNums = new int[inputVals.Length];
            for (int i = 0; i < arrNums.Length; i++)
            {
                arrNums[i] = int.Parse(inputVals[i]);
            }
            //     0   1  2  3 tempArr[j - 1]
            // 0   1   2  3  4 arrNums[j]       [tempArr]
            //[51] 47 32 61 21;              {47 32 61 21 [51]};   32 61 21 51 47
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                int firstElemnt = arrNums[0];
                int[] tempArr = new int[arrNums.Length]; // it's like int temp = 0; With every loop it's initialized int[] temp = new int[] { 0, 0, 0,...0 } with default val of 0-s;
                for (int j = 1; j < arrNums.Length; j++)
                {
                    tempArr[j - 1] = arrNums[j];
                }
                tempArr[arrNums.Length - 1] = firstElemnt;
                arrNums = tempArr;
            }
            foreach (int value in arrNums)
            {
                Console.Write("{0} ", value);
            }
        }
    }
}
