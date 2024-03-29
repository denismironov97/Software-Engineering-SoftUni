﻿using System;
using System.Text;

namespace Ex._06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            char previusSymbol = '\0';
            StringBuilder resultMessage = new StringBuilder();

            foreach (char symbol in message)
            {
                if (symbol != previusSymbol)
                {
                    resultMessage.Append(symbol);
                    previusSymbol = symbol;
                }
            }

            Console.WriteLine(resultMessage);
        }
    }
}
