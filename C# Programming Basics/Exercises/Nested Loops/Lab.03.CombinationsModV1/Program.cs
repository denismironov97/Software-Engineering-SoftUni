using System;

namespace Lab._03.CombinationsModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int counterValidCombinations = 0;

            while (x1 <= n)
            {
                while (x2 <= n)
                {
                    while (x3 <= n)
                    {
                        if (x1 + x2 + x3 == n)
                        {
                            counterValidCombinations += 1;
                        }
                        x3++;
                    }
                    x3 = 0;
                    x2++;
                }
                x2 = 0;
                x1++;
            }

            Console.WriteLine(counterValidCombinations);
        }
    }
}
