using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._08.BalancedParenthesisModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<char> bracketsStack = new Stack<char>();
            bool firstElementIsClosingBracket = expression[0] == ')' || expression[0] == ']' || expression[0] == '}';

            if (firstElementIsClosingBracket)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (char currSymbol in expression)
            {
                if (bracketsStack.Any())
                {
                    char openingBracket = bracketsStack.Peek();

                    if (openingBracket == '{' && currSymbol == '}')
                    {
                        bracketsStack.Pop();
                        continue;
                    }
                    else if (openingBracket == '[' && currSymbol == ']')
                    {
                        bracketsStack.Pop();
                        continue;
                    }
                    else if (openingBracket == '(' && currSymbol == ')')
                    {
                        bracketsStack.Pop();
                        continue;
                    }
                }

                bracketsStack.Push(currSymbol);
            }

            string resusltMessage = bracketsStack.Count == 0 ? "YES" : "NO";
            Console.WriteLine(resusltMessage);
        }
    }
}
