using System;

namespace Ex._06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            FindsMiddleCharacter(input);
        }

        static void FindsMiddleCharacter(string inputString)
        {
            // 0 1 2  3  4 5 6 7     
            // a S t  r  i n g       // r 7 lenght
            // s o m  e  T e x t     // eT
            int lenght = inputString.Length;
            if (lenght % 2 == 0) // even lenght
            {
                Console.Write(inputString[(inputString.Length / 2) - 1]);
                Console.WriteLine(inputString[inputString.Length / 2]);
            }
            else // odd lenght
            {

                Console.WriteLine(inputString[inputString.Length / 2]);
            }
        }
    }
}
