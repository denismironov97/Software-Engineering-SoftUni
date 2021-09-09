using System;

namespace Ex._07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }

        static void PrintMatrix(int n)
        {
            for (int row = 1; row <= n; row++) // rows
            {
                for (int col = 1; col <= n; col++) // collons
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
