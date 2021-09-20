using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] commands = input.Split(); //commmands
                string operationTask = commands[0]; //operation
                switch (operationTask)
                {
                    case "Add":
                        int number = int.Parse(commands[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        if (index >= 0 && index < numbers.Count) //can insert
                        {
                            numbers.Insert(index, number);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        index = int.Parse(commands[1]);
                        if (index >= 0 && index < numbers.Count) //can insert
                        {
                            numbers.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(commands[2]);
                        if (commands[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int firstNum = numbers[0];
                                numbers.Add(firstNum);
                                numbers.RemoveAt(0);
                            }
                        }
                        else // "right"
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int lastNum = numbers[numbers.Count - 1];
                                numbers.Insert(0, lastNum);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
