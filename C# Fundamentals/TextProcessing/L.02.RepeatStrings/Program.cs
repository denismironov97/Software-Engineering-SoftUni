using System;

namespace L._02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(" ");
            int lenghtinputData = inputData.Length;
            string resultOutput = string.Empty;

            for (int i = 0; i < lenghtinputData; i++)
            {
                int wordLeght = inputData[i].Length;

                for (int j = 0; j < wordLeght; j++)
                {
                    resultOutput += inputData[i];
                }
            }

            Console.WriteLine(resultOutput);
        }
    }
}
