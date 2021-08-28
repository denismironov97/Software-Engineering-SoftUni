using System;

namespace Ex._03.ZigZagArrays
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
                string inputValString = Console.ReadLine();
                string[] arrInputValString = inputValString.Split(' ');
                int[] arrInputValNums = new int[arrInputValString.Length];
                for (int j = 0; j < arrInputValNums.Length; j++)
                {
                    arrInputValNums[j] = int.Parse(arrInputValString[j]);
                }

                if (i % 2 == 0)//even row
                {
                    array1[i] = arrInputValNums[0];
                    array2[i] = arrInputValNums[1];
                }
                else//odd row
                {
                    array1[i] = arrInputValNums[1];
                    array2[i] = arrInputValNums[0];
                }
            }

            foreach (int arr1Num in array1)
            {
                Console.Write($"{arr1Num} ");
            }

            Console.WriteLine();

            foreach (int arrNum2 in array2)
            {
                Console.Write($"{arrNum2} ");
            }
        }
    }
}
