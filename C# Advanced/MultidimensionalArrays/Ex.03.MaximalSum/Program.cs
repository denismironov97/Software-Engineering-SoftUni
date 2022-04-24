using System;
using System.Linq;

namespace Ex._03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            int[,] matrix = new int[rows, columns];
            ReadMatrix(matrix);

            int square3x3MaxSum = int.MinValue;
            int[,] square3x3 = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSquare3x3Sum = matrix[row, col] +
                                           matrix[row, col + 1] +
                                           matrix[row, col + 2] +
                                           matrix[row + 1, col] +
                                           matrix[row + 1, col + 1] +
                                           matrix[row + 1, col + 2] +
                                           matrix[row + 2, col] +
                                           matrix[row + 2, col + 1] +
                                           matrix[row + 2, col + 2];

                    if (currSquare3x3Sum > square3x3MaxSum)
                    {
                        square3x3MaxSum = currSquare3x3Sum;

                        square3x3[0, 0] = matrix[row, col];
                        square3x3[0, 1] = matrix[row, col + 1];
                        square3x3[0, 2] = matrix[row, col + 2];
                        square3x3[1, 0] = matrix[row + 1, col];
                        square3x3[1, 1] = matrix[row + 1, col + 1];
                        square3x3[1, 2] = matrix[row + 1, col + 2];
                        square3x3[2, 0] = matrix[row + 2, col];
                        square3x3[2, 1] = matrix[row + 2, col + 1];
                        square3x3[2, 2] = matrix[row + 2, col + 2];
                    }
                }
            }

            Console.WriteLine($"Sum = {square3x3MaxSum}");
            PrintMatix(square3x3);
        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currRowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRowElements[col];
                }
            }
        }

        private static void PrintMatix(int[,] matrixAr)
        {
            for (int row = 0; row < matrixAr.GetLength(0); row++)
            {
                for (int col = 0; col < matrixAr.GetLength(1); col++)
                {
                    Console.Write(matrixAr[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
