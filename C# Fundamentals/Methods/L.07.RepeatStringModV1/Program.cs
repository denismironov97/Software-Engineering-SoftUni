using System;

namespace L._07.RepeatStringModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] result = PrintLine(n, input);
            Console.WriteLine(string.Join("", result));
        }
        static string[] PrintLine(int nCopyedVal, string inputCopyedVal)
        {
            string[] arrCollection = new string[nCopyedVal];
            for (int i = 0; i < arrCollection.Length; i++)
            {
                arrCollection[i] = inputCopyedVal;
            }
            return arrCollection;
        }
    }
}
