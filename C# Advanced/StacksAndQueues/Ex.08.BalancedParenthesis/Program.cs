using System;
using System.Collections.Generic;

namespace Ex._08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            // {[( )]}   [0]-[5] length = 6
            // ()(())
            //{{[[(( ))]]}}
            string expression = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool firstElementIsClosingBracket = expression[0] == ')' || expression[0] == ']' || expression[0] == '}';

            if (firstElementIsClosingBracket)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < expression.Length; i++)
            {
                char currentSymbol = expression[i];
                char openingBracket;

                if (currentSymbol == '(' || currentSymbol == '[' || currentSymbol == '{')
                {
                    stack.Push(currentSymbol);
                }
                else if (currentSymbol == ')')
                {
                    openingBracket = stack.Peek();

                    if (openingBracket == '(')
                    {
                        stack.Pop();
                    }
                }
                else if (currentSymbol == ']')
                {
                    openingBracket = stack.Peek();

                    if (openingBracket == '[')
                    {
                        stack.Pop();
                    }
                }
                else if (currentSymbol == '}')
                {
                    openingBracket = stack.Peek();

                    if (openingBracket == '{')
                    {
                        stack.Pop();
                    }
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
