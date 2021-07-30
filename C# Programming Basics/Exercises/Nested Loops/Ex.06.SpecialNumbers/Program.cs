using System;

namespace Ex._06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (numN % i == 0 && numN % j == 0 && numN % k == 0 && numN % l == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }

                        }
                    }
                }
            }
        }
    }
}
