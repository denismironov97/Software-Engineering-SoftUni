using System;

namespace Ex._07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensionsOfBoard = int.Parse(Console.ReadLine());
            int rows = dimensionsOfBoard;
            int columns = dimensionsOfBoard;
            char[,] chessBoard = new char[rows, columns];
            ReadMatrix(chessBoard);

            int countOfKReplaced = 0;
            int rowOfKnightCordinates = 0;
            int colOfKnightCoordinates = 0;

            while (true)
            {
                int maxAttacks = int.MinValue;

                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        char currentSymbol = chessBoard[row, col];
                        int countOfAttacks = 0;

                        if (currentSymbol == 'K')
                        {
                            countOfAttacks = GetNumOfAttacks(chessBoard, row, col, countOfAttacks);

                            if (countOfAttacks > maxAttacks)
                            {
                                maxAttacks = countOfAttacks;
                                rowOfKnightCordinates = row;
                                colOfKnightCoordinates = col;
                            }
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    chessBoard[rowOfKnightCordinates, colOfKnightCoordinates] = '0';
                    countOfKReplaced++;
                }
                else if (maxAttacks == 0)
                {
                    break;
                }
            }

            Console.WriteLine(countOfKReplaced);
        }

        static void ReadMatrix(char[,] chessBoard)
        {
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = currentRow[col];
                }
            }
        }

        static bool ValidCoordinatesForKnightToAttack(char[,] chessBoard, int rowTarget, int colTarget)
        {
            return rowTarget >= 0 && rowTarget < chessBoard.GetLength(0)
                && colTarget >= 0 && colTarget < chessBoard.GetLength(1);
        }

        static int GetNumOfAttacks(char[,] chessBoard, int row, int col, int countOfAttacks)
        {
            if (ValidCoordinatesForKnightToAttack(chessBoard, row + 2, col - 1))
            {
                if (chessBoard[row + 2, col - 1] == 'K')
                {
                    countOfAttacks++;
                }
            }

            if (ValidCoordinatesForKnightToAttack(chessBoard, row + 2, col + 1))
            {
                if (chessBoard[row + 2, col + 1] == 'K')
                {
                    countOfAttacks++;
                }
            }

            if (ValidCoordinatesForKnightToAttack(chessBoard, row + 1, col - 2))
            {
                if (chessBoard[row + 1, col - 2] == 'K')
                {
                    countOfAttacks++;
                }
            }

            if (ValidCoordinatesForKnightToAttack(chessBoard, row + 1, col + 2))
            {
                if (chessBoard[row + 1, col + 2] == 'K')
                {
                    countOfAttacks++;
                }
            }

            if (ValidCoordinatesForKnightToAttack(chessBoard, row - 1, col - 2))
            {
                if (chessBoard[row - 1, col - 2] == 'K')
                {
                    countOfAttacks++;
                }
            }

            if (ValidCoordinatesForKnightToAttack(chessBoard, row - 1, col + 2))
            {
                if (chessBoard[row - 1, col + 2] == 'K')
                {
                    countOfAttacks++;
                }
            }

            if (ValidCoordinatesForKnightToAttack(chessBoard, row - 2, col - 1))
            {
                if (chessBoard[row - 2, col - 1] == 'K')
                {
                    countOfAttacks++;
                }
            }

            if (ValidCoordinatesForKnightToAttack(chessBoard, row - 2, col + 1))
            {
                if (chessBoard[row - 2, col + 1] == 'K')
                {
                    countOfAttacks++;
                }
            }

            return countOfAttacks;
        }
    }
}
