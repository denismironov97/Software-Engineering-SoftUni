using System;
using System.Linq;

namespace Ex._01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[,] squareMatrix = new int[rows, rows];
            ReadMatrix(squareMatrix);
            int primaryDiagonalSum = CalculatePrimaryDiagonalVer4(squareMatrix);
            int secondaryDiagonalSum = 0;

            int indexCol = 0;
            for (int row = squareMatrix.GetLength(0) - 1; row >= 0; row--)//Secondary Diagonal Sum Calculation
            {
                secondaryDiagonalSum += squareMatrix[row, indexCol];
                indexCol++;
            }

            int diffAbs = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(diffAbs);
        }

        private static int CalculatePrimaryDiagonalVer1(int[,] squareMatrix)
        {
            int primaryDiagonalSum = 0;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)//Primary Diagonal Sum version 1
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        primaryDiagonalSum += squareMatrix[row, col];
                    }
                }
            }

            return primaryDiagonalSum;
        }

        private static int CalculatePrimaryDiagonalVer2(int[,] squareMatrix)
        {
            int primaryDiagonalSum = 0;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)//Primary Diagonal Sum version 2 not very correct utilisation of for cyckle structure
            {
                for (int col = row; col < squareMatrix.GetLength(1);)
                {
                    primaryDiagonalSum += squareMatrix[row, col];
                    break;
                }
            }

            return primaryDiagonalSum;
        }

        private static int CalculatePrimaryDiagonalVer3(int[,] squareMatrix)
        {
            int primaryDiagonalSum = 0;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)//Primary Diagonal Sum version 3
            {
                int col = row;
                primaryDiagonalSum += squareMatrix[row, col];
            }

            return primaryDiagonalSum;
        }

        private static int CalculatePrimaryDiagonalVer4(int[,] squareMatrix)
        {
            int primaryDiagonalSum = 0;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)//Primary Diagonal Sum version 4
            {
                primaryDiagonalSum += squareMatrix[row, row];
            }

            return primaryDiagonalSum;
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
