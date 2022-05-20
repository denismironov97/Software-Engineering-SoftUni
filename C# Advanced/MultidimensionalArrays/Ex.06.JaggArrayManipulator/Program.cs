using System;
using System.Linq;

namespace Ex._06.JaggArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];
            ReadJaggedArrayVer1(jaggedArray);

            for (int row = 1; row < jaggedArray.Length; row++)
            {
                double[] previusRow = jaggedArray[row - 1];
                double[] currRow = jaggedArray[row];

                if (previusRow.Length == currRow.Length)//even length
                {
                    //for (int i = 0; i < previusRow.Length; i++)
                    //{
                    //    previusRow[i] *= 2;
                    //}

                    //for (int i = 0; i < currRow.Length; i++)
                    //{
                    //    currRow[i] *= 2;
                    //}

                    jaggedArray[row - 1] = jaggedArray[row - 1].Select(x => x * 2).ToArray();
                    jaggedArray[row] = jaggedArray[row].Select(x => x * 2).ToArray();
                }
                else
                {
                    //for (int i = 0; i < previusRow.Length; i++)
                    //{
                    //    previusRow[i] /= 2;
                    //}

                    //for (int i = 0; i < currRow.Length; i++)
                    //{
                    //    currRow[i] /= 2;
                    //}

                    jaggedArray[row - 1] = jaggedArray[row - 1].Select(x => x / 2).ToArray();
                    jaggedArray[row] = jaggedArray[row].Select(x => x / 2).ToArray();
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string instruction = commandParts[0];
                int rowCoordinate = int.Parse(commandParts[1]);
                int colCoordinate = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                if (CheckForValidCoordinates(jaggedArray, rowCoordinate, colCoordinate))
                {
                    if (instruction == "Add")
                    {
                        jaggedArray[rowCoordinate][colCoordinate] += value;
                    }
                    else
                    {
                        jaggedArray[rowCoordinate][colCoordinate] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            PrintJaggedArray(jaggedArray);
        }

        private static void ReadJaggedArrayVer1(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                double[] currRowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jaggedArray[row] = new double[currRowElements.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = currRowElements[col];
                }
            }
        }

        private static void ReadJaggedArrayVer2(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                double[] currRowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jaggedArray[row] = currRowElements;
            }
        }

        private static bool CheckForValidCoordinates(double[][] jaggedArray, int rowCoordinate, int colCoordinate)
        {
            if (rowCoordinate >= 0 && rowCoordinate < jaggedArray.Length
                && colCoordinate >= 0 && colCoordinate < jaggedArray[rowCoordinate].Length)
            {
                return true;
            }

            return false;
        }

        private static void PrintJaggedArray(double[][] jaggedArray)
        {
            foreach (double[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }


}
