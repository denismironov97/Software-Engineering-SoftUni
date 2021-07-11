using System;

namespace Lab._05.CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int lenght = word.Length;
            
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
    }
}
