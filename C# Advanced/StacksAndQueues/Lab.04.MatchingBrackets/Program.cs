using System;
using System.Collections.Generic;

namespace Lab._04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            Stack<int> startingIndicesOfOpeningBrackets = new Stack<int>();
            List<string> brackeExpressiontCollection = new List<string>();

            for (int i = 0; i < inputData.Length; i++)
            {
                char symbol = inputData[i];

                if (symbol == '(')
                {
                    startingIndicesOfOpeningBrackets.Push(i);

                }
                else if (symbol == ')')
                {
                    int startIndex = startingIndicesOfOpeningBrackets.Pop();
                    string bracketExpression = inputData.Substring(startIndex, i - startIndex + 1);
                    brackeExpressiontCollection.Add(bracketExpression);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, brackeExpressiontCollection));
        }
    }
}
