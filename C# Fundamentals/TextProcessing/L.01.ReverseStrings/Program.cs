using System;

namespace L._01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // hello

            while (input != "end")
            {
                string reversedInput = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedInput += input[i];
                }

                Console.WriteLine($"{input} = {reversedInput}");
                input = Console.ReadLine();
            }
        }
    }
}
