using System;

namespace Ex._02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStringsData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long result = GetProductSumOfTwoStrings(inputStringsData[0], inputStringsData[1]);
            Console.WriteLine(result);
        }

        private static long GetProductSumOfTwoStrings(string text1, string text2)
        {
            int textMinLength = Math.Min(text1.Length, text2.Length);
            int textMaxLength = Math.Max(text1.Length, text2.Length);
            long productSum = 0;

            for (int i = 0; i < textMinLength; i++)
            {
                productSum = productSum + (text1[i] * text2[i]);
            }

            if (text1.Length > text2.Length)
            {
                productSum += SumRemainingChars(textMinLength, textMaxLength, text1);
            }
            else if (text2.Length > text1.Length)
            {
                productSum += SumRemainingChars(textMinLength, textMaxLength, text2);
            }

            return productSum;
        }

        private static int SumRemainingChars(int startIndex, int endIndex, string text)
        {
            int sumOfChars = 0;

            for (int i = startIndex; i < endIndex; i++)
            {
                sumOfChars += text[i];
            }

            return sumOfChars;
        }
    }
}
