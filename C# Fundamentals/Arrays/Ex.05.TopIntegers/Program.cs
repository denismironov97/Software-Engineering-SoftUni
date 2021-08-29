using System;

namespace Ex._05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValues = Console.ReadLine();
            string[] arrString = inputValues.Split(' ');
            int[] arrValues = new int[arrString.Length];//
            for (int i = 0; i < arrValues.Length; i++)
            {
                arrValues[i] = int.Parse(arrString[i]);
            }
            // 1 4 3 2
            for (int i = 0; i < arrValues.Length; i++)
            {
                bool isBigger = true;
                for (int j = i + 1; j < arrValues.Length; j++)
                {
                    if (arrValues[i] <= arrValues[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(arrValues[i] + " ");
                }
            }
        }
    }
}
