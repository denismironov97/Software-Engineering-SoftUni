using System;

namespace Ex._03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            PrintASCIIChars(firstSymbol: symbol1, secondSymbol: symbol2); //= PritnLine(symbol1, symbol2):
        }

        static void PrintASCIIChars(char firstSymbol, char secondSymbol)
        {
            int symb1 = firstSymbol; //integer representation of char in the ASCII table
            int symb2 = secondSymbol;
            if (symb1 < symb2)
            {
                for (int i = symb1 + 1; i < symb2; i++)
                {
                    Console.Write("{0} ", (char)i);
                }
                return;
            }
            for (int i = symb2 + 1; i < symb1; i++)
            {
                Console.Write("{0} ", (char)i);
            }
        }
    }
}
