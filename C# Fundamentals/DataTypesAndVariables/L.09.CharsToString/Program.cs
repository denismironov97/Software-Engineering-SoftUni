using System;

namespace L._09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                char inputSymbol = char.Parse(Console.ReadLine());
                output += inputSymbol;
            }
            Console.WriteLine(output);
        }
    }
}
