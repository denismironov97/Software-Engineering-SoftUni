using System;
using System.Linq;

namespace Ex._02._SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            char[,] matrix = new char[rows, columns];
            ReadMatrix(matrix);

            char[,] squareSymbolBuffer = new char[2, 2];
            int countSquareOfEqualSymbols = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    squareSymbolBuffer[0, 0] = matrix[row, col];
                    squareSymbolBuffer[0, 1] = matrix[row, col + 1];
                    squareSymbolBuffer[1, 0] = matrix[row + 1, col];
                    squareSymbolBuffer[1, 1] = matrix[row + 1, col + 1];

                    if (squareSymbolBuffer[0, 0] == squareSymbolBuffer[0, 1]
                        && squareSymbolBuffer[0, 0] == squareSymbolBuffer[1, 0]
                        && squareSymbolBuffer[0, 1] == squareSymbolBuffer[1, 1])
                    {
                        countSquareOfEqualSymbols++;
                    }

                }
            }

            Console.WriteLine(countSquareOfEqualSymbols);
        }

        private static void ReadMatrix(char[,] matrixFill)
        {
            for (int row = 0; row < matrixFill.GetLength(0); row++)
            {
                char[] currRowColumnElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrixFill.GetLength(1); col++)
                {
                    matrixFill[row, col] = currRowColumnElements[col];
                }
            }
        }
    }
}
