using System;

namespace Ex._01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int collons = 1; collons <= rows; collons++)
                {
                    Console.Write(number + " ");
                    number++;
                    if (number > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (number > n)
                {
                    break;
                }
            }
        }
    }
}
