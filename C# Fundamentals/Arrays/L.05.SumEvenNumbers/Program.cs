using System;

namespace L._05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrString = Console.ReadLine().Split();
            int[] arrayNum = new int[arrString.Length];
            int sum = 0;
            for (int i = 0; i < arrString.Length; i++)
            {
                arrayNum[i] = int.Parse(arrString[i]);
                if (arrayNum[i] % 2 == 0)
                {
                    sum = sum + arrayNum[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
