using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Allie is going!
            //  0     1   2
            // John is not going!
            //   0  1   2    3
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> peopleOnList = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                bool going = command.Count == 3;
                if (going)
                {
                    string name = command[0];
                    if (peopleOnList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        peopleOnList.Add(name);
                    }
                }
                else //not going 
                {
                    string name = command[0];
                    if (peopleOnList.Contains(name) == false)
                    {
                        Console.WriteLine("{0} is not in the list!", name);
                    }
                    else
                    {
                        peopleOnList.Remove(name);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, peopleOnList));
        }
    }
}
