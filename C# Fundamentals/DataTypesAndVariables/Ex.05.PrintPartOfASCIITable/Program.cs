using System;

namespace Ex._05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startSymbol = int.Parse(Console.ReadLine());
            int endSymbol = int.Parse(Console.ReadLine());

            for (int i = startSymbol; i <= endSymbol; i++)
            {
                Console.Write("{0} ", (char)i);
            }
        }
    }
}
