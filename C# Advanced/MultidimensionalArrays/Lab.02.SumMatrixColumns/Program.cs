using System;
using System.Linq;

namespace Lab._02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            int[,] matrix = new int[rows, columns];
            int[] columnsSum = new int[columns];

            for (int row = 0; row < matrix.GetLength(0); row++) // rows
            {
                int[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++) // columns
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int currentElement = matrix[row, col];
                    columnsSum[col] += currentElement;
                }
            }

            foreach (int colSum in columnsSum)
            {
                Console.WriteLine(colSum);
            }
        }
    }
}
