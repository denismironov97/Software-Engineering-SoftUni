using System;
using System.Linq;

namespace Lab._05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int submatrix2x2MaxSum = int.MinValue;
            int[,] squareMatrix = new int[2, 2];

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSquareSum = matrix[row, col] +
                                           matrix[row, col + 1] +
                                           matrix[row + 1, col] +
                                           matrix[row + 1, col + 1];

                    if (currentSquareSum > submatrix2x2MaxSum)
                    {
                        submatrix2x2MaxSum = currentSquareSum;

                        squareMatrix[0, 0] = matrix[row, col];
                        squareMatrix[0, 1] = matrix[row, col + 1];
                        squareMatrix[1, 0] = matrix[row + 1, col];
                        squareMatrix[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    Console.Write(squareMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(submatrix2x2MaxSum);
        }
    }
}
