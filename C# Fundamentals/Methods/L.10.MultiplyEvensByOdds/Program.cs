using System;

namespace L._10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            string inputNumString = inputNum.ToString();
            int sumOdd = 0;
            int sumEven = 0;
            int product = 0;
            int endResult = GetMultipleOfEvenAndOdds(inputNumString, sumOdd, sumEven, product);
            Console.WriteLine(endResult);
        }
        static int GetMultipleOfEvenAndOdds(string inputNumString, int sumOdd, int sumEven, int product)
        {
            for (int i = 0; i < inputNumString.Length; i++)
            {
                if (inputNumString[i] == '-')
                {
                    continue;
                }
                int currentDigit = inputNumString[i] - 48; // returns ASCII num representation;
                if (currentDigit % 2 == 0) // even
                {
                    sumOdd += currentDigit;
                }
                else // odd
                {
                    sumEven += currentDigit;
                }
                product = sumOdd * sumEven;
            }
            return product;
        }
    }
}
