using System;

namespace Lab._07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[rows][];

            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                long[] colum = new long[row + 1];
                pascalTriangle[row] = colum;

                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    if (col > 0 && col < pascalTriangle[row].Length - 1)
                    {
                        pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                    }
                    else
                    {
                        pascalTriangle[row][col] = 1;
                    }
                }
            }

            foreach (long[] pascalRow in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", pascalRow));
            }
        }
    }
}
