using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._01.ReverseStringsModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversedInput = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                reversedInput.Push(letter);
            }

            foreach (char symbol in reversedInput)
            {
                Console.Write(symbol);
            }
        }
    }
}
