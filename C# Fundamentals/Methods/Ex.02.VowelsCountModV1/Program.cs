using System;

namespace Ex._02.VowelsCountModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelsSum = GetVowelsCount(input);
            Console.WriteLine(vowelsSum);
        }

        private static int GetVowelsCount(string inputMsg)
        {
            int sumVowels = 0;
            foreach (char symbol in inputMsg)
            {
                switch (symbol)
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                    case 'y':
                    case 'Y':
                        sumVowels++;
                        break;
                }
            }

            return sumVowels;
        }
    }
}
