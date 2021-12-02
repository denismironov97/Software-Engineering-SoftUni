using System;

namespace L._04.TextFilterModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banListOfWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            Solution01(banListOfWords, text);
        }
        private static void Solution01(string[] banlist, string textToEdit)
        {
            foreach (string banWord in banlist)
            {
                string replacement = string.Empty;

                for (int i = 0; i < banWord.Length; i++)
                {
                    replacement += "*";
                }

                if (textToEdit.Contains(banWord))
                {
                    textToEdit = textToEdit.Replace(banWord, replacement);
                }
            }

            Console.WriteLine(textToEdit);
        }
    }
}
