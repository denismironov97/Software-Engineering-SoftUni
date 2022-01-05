using System;
using System.Numerics;

namespace Ex._05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number1 = BigInteger.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            BigInteger product = number1 * number2;
            Console.WriteLine(product);
        }
    }
}
