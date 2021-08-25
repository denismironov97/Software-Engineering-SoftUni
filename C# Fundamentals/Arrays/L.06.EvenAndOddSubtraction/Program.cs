using System;

namespace L._06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrString = Console.ReadLine().Split();
            int[] arrInt = new int[arrString.Length];
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < arrString.Length; i++)
            {
                arrInt[i] = int.Parse(arrString[i]);
                if (arrInt[i] % 2 == 0)
                {
                    sumEven += arrInt[i];
                }
                else
                {
                    sumOdd += arrInt[i];
                }
            }
            int difference = 0;
            difference = sumEven - sumOdd;
            Console.WriteLine(difference);
        }
    }
}
