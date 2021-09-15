using System;
using System.Linq;
using System.Collections.Generic;

namespace L._06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            List<int> resultList = GetListManipulation(numbers, command);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> GetListManipulation(List<int> numbers, string command)
        {
            while (command != "end")
            {
                string[] currentCommand = command.Split();
                if (currentCommand[0] == "Add")
                {
                    int numberToAdd = int.Parse(currentCommand[1]);
                    numbers.Add(numberToAdd);
                }
                else if (currentCommand[0] == "Remove")
                {
                    int numberToRemove = int.Parse(currentCommand[1]);
                    numbers.Remove(numberToRemove);

                }
                else if (currentCommand[0] == "RemoveAt")
                {
                    int index = int.Parse(currentCommand[1]);
                    numbers.RemoveAt(index);
                }
                else if (currentCommand[0] == "Insert")
                {
                    int numberToIncerst = int.Parse(currentCommand[1]);
                    int index = int.Parse(currentCommand[2]);
                    numbers.Insert(index, numberToIncerst);
                }
                command = Console.ReadLine();
            }
            return numbers;
        }
    }
}
