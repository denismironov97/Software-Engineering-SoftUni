using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace L._01.MatchFullNameModV3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            MatchCollection validNames = regex.Matches(text);

            //string[] nameCollection = new string[2];
            List<string> nameCollection = new List<string>();

            foreach (Match name in validNames)
            {
                nameCollection.Add(name.Value);
            }

            Console.WriteLine(string.Join(" ", nameCollection));
        }
    }
}
