using System;

namespace L._07.RepeatStringModV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] result = PrintLine(n, input);
            foreach (string text in result)
            {
                Console.Write(text);
            }
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
