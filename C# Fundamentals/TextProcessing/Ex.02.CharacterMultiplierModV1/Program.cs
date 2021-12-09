using System;

namespace Ex._02.CharacterMultiplierModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStringsData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long result = GetProductOfTwoStrings(inputStringsData[0], inputStringsData[1]);
            Console.WriteLine(result);
        }

        private static long GetProductOfTwoStrings(string text1, string text2)
        {
            int text1Length = text1.Length;
            int text2Length = text2.Length;
            int textMinLength = Math.Min(text1Length, text2Length);
            int textMaxLength = Math.Max(text1Length, text2Length);
            int difference = textMaxLength - textMinLength;

            long productSum = 0;

            for (int i = 0; i < textMinLength; i++)
            {
                productSum += text1[i] * text2[i];
            }

            if (text1Length > text2Length)
            {
                for (int i = textMaxLength - difference; i < textMaxLength; i++)
                {
                    productSum += text1[i];
                }
            }
            else if (text1Length < text2Length)
            {
                for (int i = textMaxLength - difference; i < textMaxLength; i++)
                {
                    productSum += text2[i];
                }
            }

            return productSum;
        }
    }
}
