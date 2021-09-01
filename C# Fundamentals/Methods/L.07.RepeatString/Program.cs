using System;

namespace L._07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = PrintLine(n, input);
            Console.WriteLine(result);
        }
        static string PrintLine(int n, string input)
        {
            string collection = string.Empty;
            for (int i = 0; i < n; i++)
            {
                collection += input;
            }
            return collection;
        }
    }
}
