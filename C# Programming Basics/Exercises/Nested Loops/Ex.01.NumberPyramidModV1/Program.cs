using System;

namespace Ex._01.NumberPyramidModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = 1;
            int collons = 1;
            int number = 1;
            bool numIsBigger = false;

            while (rows <= n)
            {
                while (collons <= rows)
                {
                    Console.Write(number + " ");
                    number++;
                    collons++;

                    if (number > n)
                    {
                        numIsBigger = true;
                        break;
                    }
                }

                collons = 1;
                rows++;
                Console.WriteLine();

                if (numIsBigger)
                {
                    break;
                }
            }
        }
    }
}
