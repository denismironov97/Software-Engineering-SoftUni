using System;
using System.Collections.Generic;

namespace Ex._05.MultiplyBigNumberModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            int remainder = 0;
            List<string> resultProduct = new List<string>();

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int currentDigit = num1[i] - 48;
                remainder = remainder + (multiplier * currentDigit);

                if (remainder > 9)
                {
                    int remainderLastDigit = remainder % 10;
                    remainder = remainder / 10;
                    resultProduct.Add(remainderLastDigit.ToString());
                }
                else // <= 9
                {
                    resultProduct.Add(remainder.ToString());
                    remainder = 0;
                }
            }

            if (remainder > 0)
            {
                resultProduct.Add(remainder.ToString());
            }

            resultProduct.Reverse();
            Console.WriteLine(string.Join(string.Empty, resultProduct));
        }
    }
}
