using System;

namespace Ex._02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetVowelsCount(input);
        }

        static void GetVowelsCount(string input)
        {
            int sumVowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'A':
                        sumVowels++;
                        break;
                    case 'e':
                    case 'E':
                        sumVowels++;
                        break;
                    case 'i':
                    case 'I':
                        sumVowels = sumVowels + 1;
                        break;
                    case 'o':
                    case 'O':
                        sumVowels += 1;
                        break;
                    case 'u':
                    case 'U':
                        sumVowels++;
                        break;
                    case 'y':
                    case 'Y':
                        sumVowels++;
                        break;
                }
            }
            Console.WriteLine(sumVowels);
        }
    }
}
