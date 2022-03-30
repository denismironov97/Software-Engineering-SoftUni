using System;
using System.Linq;

namespace Lab._03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());//square 
            int rows = dimensions;
            int columns = dimensions;
            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++) //rows
            {
                int[] currentRow = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++) //columns
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int sumOfmatrixPrimaryDiagonal = 0;
            /*
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1);)
                {
                    int primaryDiagonalNum = matrix[row, col];
                    sumOfmatrixPrimaryDiagonal += primaryDiagonalNum;
                    break;
                }
            }
            */

            /*
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int col = row;
                int primaryDiagonalNum = matrix[row, col];
                sumOfmatrixPrimaryDiagonal += primaryDiagonalNum;
            }
            */

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //Since it's a square this means that rows = cols
                int primaryDiagonalNum = matrix[row, row];
                sumOfmatrixPrimaryDiagonal += primaryDiagonalNum;
            }

            Console.WriteLine(sumOfmatrixPrimaryDiagonal);
        }
    }
}
