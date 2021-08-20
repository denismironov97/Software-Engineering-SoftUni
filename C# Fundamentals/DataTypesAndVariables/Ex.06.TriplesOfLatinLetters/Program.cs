using System;

namespace Ex._06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNum = int.Parse(Console.ReadLine()); // 3-> abc

            for (int i = 0; i < nNum; i++)
            {
                for (int j = 0; j < nNum; j++)
                {
                    for (int k = 0; k < nNum; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
