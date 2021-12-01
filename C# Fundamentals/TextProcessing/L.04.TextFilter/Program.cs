using System;

namespace L._04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banListOfWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (string banWord in banListOfWords)
            {

                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
