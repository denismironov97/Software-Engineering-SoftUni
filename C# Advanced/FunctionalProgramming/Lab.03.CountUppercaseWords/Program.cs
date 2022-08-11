using System;
using System.Linq;

namespace Lab._03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checkIfUpperFunc = x => x[0] == x.ToUpper()[0];
            string[] words = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(checkIfUpperFunc)
                .ToArray();

            foreach (string upperWord in words)
            {
                Console.WriteLine(upperWord);
            }
        }
    }
}
