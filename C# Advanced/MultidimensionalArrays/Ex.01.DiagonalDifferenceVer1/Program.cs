using System;
using System.Linq;

namespace Ex._01.DiagonalDifferenceVer1
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int[,] squareMatrix = new int[side, side];
            ReadMatrix(squareMatrix);
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            int indexCol = squareMatrix.GetLength(0) - 1;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                primaryDiagonalSum += squareMatrix[row, row];
                secondaryDiagonalSum += squareMatrix[row, indexCol];
                indexCol--;
            }

            int diffAbs = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(diffAbs);
        }

        private static void ReadMatrix(int[,] squareMatrix)
        {
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                int[] currRowsColumnElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = currRowsColumnElements[col];
                }
            }
        }
    }
}
