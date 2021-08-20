using System;

namespace Ex._04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCharsToFollow = int.Parse(Console.ReadLine());
            int sumOfChars = 0;

            for (int i = 0; i < numOfCharsToFollow; i++)
            {
                int charRepOfAscii = char.Parse(Console.ReadLine());
                sumOfChars += charRepOfAscii;
            }

            Console.WriteLine("The sum equals: {0}", sumOfChars);
        }
    }
}
