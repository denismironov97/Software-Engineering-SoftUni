using System;
using System.Linq;
namespace Ex._09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(ChecksIfIsPalidrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool ChecksIfIsPalidrome(string text)
        {
            char[] reversedText = text.Reverse().ToArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (!(text[i] == reversedText[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
