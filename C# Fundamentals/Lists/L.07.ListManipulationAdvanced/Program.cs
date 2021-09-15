using System;
using System.Linq;
using System.Collections.Generic;

namespace L._07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int counterForChanges = 0;
            GetListManipulation(numbers, command, counterForChanges);
        }

        static void GetListManipulation(List<int> numbersTempList, string command, int changesCounter)
        {
            while (command != "end")
            {
                string[] currentCommand = command.Split();
                if (currentCommand[0] == "Contains")
                {
                    int containsNum = int.Parse(currentCommand[1]);
                    if (numbersTempList.Contains(containsNum) == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (currentCommand[0] == "PrintEven")
                {
                    foreach (int numb in numbersTempList)
                    {
                        if (numb % 2 == 0) // even
                        {
                            Console.Write($"{numb} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (currentCommand[0] == "PrintOdd")
                {
                    foreach (int numb in numbersTempList)
                    {
                        if (numb % 2 != 0) // odd
                        {
                            Console.Write($"{numb} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (currentCommand[0] == "GetSum")
                {
                    int sumOfList = 0;
                    for (int i = 0; i < numbersTempList.Count; i++)
                    {
                        sumOfList += numbersTempList[i];
                    }
                    Console.WriteLine(sumOfList);
                }
                else if (currentCommand[0] == "Filter")
                {
                    int numberFilter = int.Parse(currentCommand[2]);
                    switch (currentCommand[1])
                    {
                        case "<":
                            foreach (int num in numbersTempList)
                            {
                                if (num < numberFilter)
                                {
                                    Console.Write($"{num} ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case ">":
                            foreach (int num in numbersTempList)
                            {
                                if (num > numberFilter)
                                {
                                    Console.Write($"{num} ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case ">=":
                            foreach (int num in numbersTempList)
                            {
                                if (num >= numberFilter)
                                {
                                    Console.Write($"{num} ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        case "<=":
                            foreach (int num in numbersTempList)
                            {
                                if (num <= numberFilter)
                                {
                                    Console.Write($"{num} ");
                                }
                            }
                            Console.WriteLine();
                            break;
                    }
                }
                if (currentCommand[0] == "Add")
                {
                    int numberToAdd = int.Parse(currentCommand[1]);
                    numbersTempList.Add(numberToAdd);
                    changesCounter++;
                }
                else if (currentCommand[0] == "Remove")
                {
                    int numberToRemove = int.Parse(currentCommand[1]);
                    numbersTempList.Remove(numberToRemove);
                    changesCounter++;
                }
                else if (currentCommand[0] == "RemoveAt")
                {
                    int index = int.Parse(currentCommand[1]);
                    numbersTempList.RemoveAt(index);
                    changesCounter++;
                }
                else if (currentCommand[0] == "Insert")
                {
                    int numberToIncerst = int.Parse(currentCommand[1]);
                    int index = int.Parse(currentCommand[2]);
                    numbersTempList.Insert(index, numberToIncerst);
                    changesCounter++;
                }
                command = Console.ReadLine();
            }
            if (changesCounter > 0)
            {
                Console.WriteLine(string.Join(" ", numbersTempList));
            }
        }
    }
}
