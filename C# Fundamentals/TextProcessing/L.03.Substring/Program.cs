using System;

namespace L._03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string textTofilterOut = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            while (true)
            {
                int startIndex = text.IndexOf(textTofilterOut);

                if (startIndex < 0)
                {
                    break;
                }

                text = text.Remove(startIndex, textTofilterOut.Length);
            }

            Console.WriteLine(text);
        }
    }
}
