using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<string> command = Console.ReadLine().Split().ToList();
            //string input = Console.ReadLine();
            //List<string> commandD = input.Split().ToList();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
