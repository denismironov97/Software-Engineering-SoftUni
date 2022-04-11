using System;
using System.Linq;

namespace Lab._06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] currentRowInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggedArray[row] = currentRowInput;
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "end")
                {
                    break;
                }

                string[] commandData = command.Split();
                string instruction = commandData[0];
                int row = int.Parse(commandData[1]);
                int col = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);

                if (row < 0
                    || col < 0
                    || row >= rows
                    || jaggedArray[row].Length <= col) // valid coordinates 
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (instruction == "add")
                {
                    jaggedArray[row][col] += value;
                }
                else //subtract 
                {
                    jaggedArray[row][col] -= value;
                }
            }

            foreach (int[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
