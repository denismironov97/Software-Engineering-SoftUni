using System;

namespace L._04.PrintingTriangleModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFigure(n);
        }
        static void PrintLine(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }
        static void PrintFigure(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintLine(row);
            }

            for (int row = n - 1; row >= 1; row--)
            {
                PrintLine(row);
            }
        }
    }
}
