using System;

namespace Lab._04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            int rows = dimensions;
            int columns = dimensions;
            char[,] squareMatrix = new char[rows, columns];

            for (int row = 0; row < squareMatrix.GetLength(0); row++) //rows
            {
                //char[] currentRow = Console.ReadLine().Split(string.Empty).Select(symbol => char.Parse(symbol)).ToArray();
                char[] currentRow = Console.ReadLine().ToCharArray();
                //var currentRow = Console.ReadLine();

                for (int col = 0; col < squareMatrix.GetLength(1); col++) //columns
                {
                    squareMatrix[row, col] = currentRow[col];
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());
            int[] coordinatesOfSymbol = new int[2]; // x[0] and y[1] coordinates 
            bool isSymbolFound = false;

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    char currentElementFromMatrix = squareMatrix[row, col];

                    if (currentElementFromMatrix == symbolToFind)
                    {
                        coordinatesOfSymbol[0] = row; //x
                        coordinatesOfSymbol[1] = col; //y
                        isSymbolFound = true;
                        break;
                    }
                }

                if (isSymbolFound)
                {
                    break;
                }
            }

            if (isSymbolFound)
            {
                Console.WriteLine($"({string.Join(", ", coordinatesOfSymbol)})");
            }
            else
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }
        }
    }
}
