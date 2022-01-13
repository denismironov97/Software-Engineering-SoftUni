using System;
using System.Text.RegularExpressions;

namespace L._01.MatchFullNameModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchCollection validNames = Regex.Matches(text, pattern);

            foreach (Match name in validNames)
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}
