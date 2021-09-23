using System;
using System.Numerics;

namespace L._02.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNum = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= nNum; i++)
            {
                factorial *= i; // factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
