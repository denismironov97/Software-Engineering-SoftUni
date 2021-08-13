using System;

namespace L._06.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbolsString = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                char currentSymbol = char.Parse(Console.ReadLine());
                symbolsString += currentSymbol; //ABC
            }
            for (int i = symbolsString.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", symbolsString[i]);
            }
        }
    }
}
