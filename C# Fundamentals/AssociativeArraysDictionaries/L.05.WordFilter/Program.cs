using System;
using System.Linq;

namespace L._05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            string[] sortedWordsByEvenLength = words.Where(x => x.Length % 2 == 0).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, sortedWordsByEvenLength));
        }
    }
}
