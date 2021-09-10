using System;

namespace Ex._10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            for (int number = 0; number <= inputNum; number++)
            {
                int digitSumOfCurrentNumber = SumOfDigits(number);
                bool isDevisiable = CheckIfSumOfDigitsIsDevisible(digitSumOfCurrentNumber);
                bool hasOneOddDigit = CheckIfNumHasAtLeastOneOddDigit(number);

                if (isDevisiable && hasOneOddDigit)
                {
                    Console.WriteLine(number);
                }
            }
        }

        static int SumOfDigits(int num)
        {
            string numStringed = num.ToString();
            int sumDigits = 0;

            for (int i = 0; i < numStringed.Length; i++)
            {
                int currentDigit = numStringed[i] - 48;
                sumDigits += currentDigit;
            }

            return sumDigits;
        }

        static bool CheckIfSumOfDigitsIsDevisible(int num)
        {
            if (num % 8 == 0 || num % 16 == 0 || num % 88 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckIfNumHasAtLeastOneOddDigit(int num)
        {
            string number = num.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                int currentDigitOfNum = number[i] - 48; // the digit itself

                if (currentDigitOfNum % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
