using System;
using System.Linq;

namespace Lab._01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ParseArrayFromConsole(Console.ReadLine());
            int rows = dimensions[0];
            int columns = dimensions[1];
            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++) //matrix.GetLength(0) => rows
            {
                int[] currentRow = ParseArrayFromConsole(Console.ReadLine());

                for (int col = 0; col < matrix.GetLength(1); col++) // matrix.GetLength(1) => columns
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int sumOfElementsInMatrix = 0;

            foreach (int element in matrix)
            {
                sumOfElementsInMatrix += element;
            }

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sumOfElementsInMatrix);
        }

        private static int[] ParseArrayFromConsole(string input)
        {
            return input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
