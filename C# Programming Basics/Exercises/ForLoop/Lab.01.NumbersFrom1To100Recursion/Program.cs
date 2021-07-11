using System;

namespace Lab._01.NumbersFrom1To100Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            PrintNumbersRecursion(num);
        }

        static void PrintNumbersRecursion(int n)
        {
            if (n > 0)
            {
                PrintNumbersRecursion(n - 1);
                Console.WriteLine(n);
            }

            return;
        }
    }
}
