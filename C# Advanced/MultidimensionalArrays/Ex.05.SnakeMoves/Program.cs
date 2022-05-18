using System;
using System.Linq;

namespace Ex._05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            char[,] matrix = new char[rows, columns];

            char[] snake = Console.ReadLine().ToCharArray();
            int currLetterPosIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)//even row
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[currLetterPosIndex];
                        currLetterPosIndex++;

                        if (currLetterPosIndex == snake.Length)
                        {
                            currLetterPosIndex = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[currLetterPosIndex];
                        currLetterPosIndex++;

                        if (currLetterPosIndex == snake.Length)
                        {
                            currLetterPosIndex = 0;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrixAr)
        {
            for (int row = 0; row < matrixAr.GetLength(0); row++)
            {
                for (int col = 0; col < matrixAr.GetLength(1); col++)
                {
                    Console.Write(matrixAr[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
