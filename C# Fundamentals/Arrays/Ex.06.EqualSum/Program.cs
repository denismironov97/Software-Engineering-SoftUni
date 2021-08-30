using System;

namespace Ex._06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] arrString = inputString.Split(' ');
            int[] arrayNums = new int[arrString.Length];
            for (int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = int.Parse(arrString[i]);
            }

            // [0] [1] [2] [3] 
            //  1   2   3   3     1 2 3 
            for (int i = 0; i < arrayNums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)//left sum
                {
                    leftSum += arrayNums[j];
                }
                for (int k = i + 1; k < arrayNums.Length; k++)//right sum 
                {
                    rightSum += arrayNums[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    Environment.Exit(0);
                }
                else if (leftSum == 0 && rightSum == 0)
                {
                    Console.WriteLine(i);
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("no");
        }
    }
}
