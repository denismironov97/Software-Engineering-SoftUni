using System;
using System.Collections.Generic;

namespace Lab._01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversedInput = new Stack<char>(input);
            Console.WriteLine(string.Join("", reversedInput));
        }
    }
}
