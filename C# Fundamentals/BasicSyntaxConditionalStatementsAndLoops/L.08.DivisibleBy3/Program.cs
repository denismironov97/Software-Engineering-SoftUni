using System;

namespace L._08.DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 101; a++)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
