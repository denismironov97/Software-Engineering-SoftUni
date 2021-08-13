using System;

namespace L._05.SpecialNumbersModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNum; i++)
            {
                int sumOfDigits = 0;
                int number = i;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number /= 10; // number = number/10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
