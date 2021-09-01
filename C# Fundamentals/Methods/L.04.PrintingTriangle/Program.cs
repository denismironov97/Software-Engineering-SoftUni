using System;

namespace L._04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//3
            for (int row = 1; row <= n; row++)//rows
            {
                PrintLinesTopPyramid(row);
            }
            for (int row = n; row > 1; row--)//bottom rows
            {
                PritLinesBottomPyramid(row);
            }
        }
        static void PrintLinesTopPyramid(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }

        static void PritLinesBottomPyramid(int row)
        {
            for (int col = 1; col < row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }
    }
}
