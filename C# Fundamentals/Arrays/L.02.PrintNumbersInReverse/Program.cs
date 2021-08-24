using System;

namespace L._02.PrintNumbersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", numArray[i]);
            }
        }
    }
}
