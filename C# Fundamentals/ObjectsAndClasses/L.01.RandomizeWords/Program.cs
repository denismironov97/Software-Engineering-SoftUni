using System;

namespace L._01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome to SoftUni and have fun learning programming

            string input = Console.ReadLine();
            string[] wordsArray = input.Split(' ');
            Random random = new Random(); // obj
            for (int i = 0; i < wordsArray.Length; i++)
            {
                int randomIndex = random.Next(0, wordsArray.Length);
                string randomElement = wordsArray[randomIndex];
                string element = wordsArray[i];
                wordsArray[randomIndex] = element;
                wordsArray[i] = randomElement;
            }
            Console.WriteLine(string.Join(Environment.NewLine, wordsArray));
        }
    }
}
