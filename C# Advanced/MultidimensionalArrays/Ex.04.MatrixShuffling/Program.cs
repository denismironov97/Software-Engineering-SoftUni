using System;
using System.Linq;

namespace Ex._04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            string[,] matrix = new string[rows, columns];
            ReadMatrix(matrix);

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                //swap row1 col1 row2c col2
                string[] commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commandParts.Length == 5
                    && commandParts[0] == "swap"
                    && CheckForValidCoordinates(matrix, int.Parse(commandParts[1]), int.Parse(commandParts[2]), int.Parse(commandParts[3]), int.Parse(commandParts[4])))
                {
                    int row1Coordinate = int.Parse(commandParts[1]);
                    int col1Coordinate = int.Parse(commandParts[2]);
                    int row2Coordinate = int.Parse(commandParts[3]);
                    int col2Coordinate = int.Parse(commandParts[4]);
                    SwapMatrixValues(matrix, row1Coordinate, col1Coordinate, row2Coordinate, col2Coordinate);
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                    continue;
                }

                PrintMatrix(matrix);
            }
        }
        private static void ReadMatrix(string[,] matrixAr)
        {
            for (int row = 0; row < matrixAr.GetLength(0); row++)
            {
                string[] currRowColumnElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrixAr.GetLength(1); col++)
                {
                    matrixAr[row, col] = currRowColumnElements[col];
                }
            }
        }

        private static bool CheckForValidCoordinates(string[,] matrixAr, int row1Coordinate, int col1Coordinate, int row2Coordinate, int col2Coordinate)
        {
            if (row1Coordinate >= 0 && row1Coordinate < matrixAr.GetLength(0)
                && col1Coordinate >= 0 && col1Coordinate < matrixAr.GetLength(1)
                && row2Coordinate >= 0 && row2Coordinate < matrixAr.GetLength(0)
                && col2Coordinate >= 0 && col2Coordinate < matrixAr.GetLength(1))
            {
                return true;
            }

            return false;
        }

        private static void SwapMatrixValues(string[,] matrixAr, int row1Coordinate, int col1Coordinate, int row2Coordinate, int col2Coordinate)
        {
            string oldElement = matrixAr[row1Coordinate, col1Coordinate];
            matrixAr[row1Coordinate, col1Coordinate] = matrixAr[row2Coordinate, col2Coordinate];
            matrixAr[row2Coordinate, col2Coordinate] = oldElement;
        }

        private static void PrintMatrix(string[,] matrixAr)
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
