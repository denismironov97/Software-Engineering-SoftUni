using System;

namespace Ex._02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine()); // 543 
            int sumDigits = 0;

            while (inputNum > 0)
            {
                sumDigits += inputNum % 10;
                inputNum /= 10; // number = number/10;
            }
            Console.WriteLine(sumDigits);
        }
    }
}
