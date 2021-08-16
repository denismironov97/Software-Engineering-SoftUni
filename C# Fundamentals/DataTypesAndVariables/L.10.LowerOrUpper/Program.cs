using System;

namespace L._10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputSymbol = char.Parse(Console.ReadLine());
            int asciiNumberOfChar = inputSymbol;
            string caseSensitive = string.Empty;
            if (asciiNumberOfChar >= 96 && asciiNumberOfChar <= 127)
            {
                caseSensitive = "lower-case";
            }
            else
            {
                caseSensitive = "upper-case";
            }
            Console.WriteLine(caseSensitive);
        }
    }
}
