using System;

namespace Ex._05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sumResult = Sum(num1, num2);
            int subtractResult = Subtract(sumReturned: sumResult, num3Copied: num3);
            Console.WriteLine(subtractResult);
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Subtract(int sumReturned, int num3Copied)
        {
            return sumReturned - num3Copied;
        }
    }
}
