using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Stack<int> numbers = new Stack<int>(numsInput);

            Stack<int> numbers = new Stack<int>();

            foreach (int number in numsInput)
            {
                numbers.Push(number);
            }

            string commandData = string.Empty;

            while ((commandData = Console.ReadLine().ToLower()) != "end")
            {
                string[] commandInformation = commandData.Split();

                switch (commandInformation[0])
                {
                    case "add":
                        numbers.Push(int.Parse(commandInformation[1]));
                        numbers.Push(int.Parse(commandInformation[2]));
                        break;
                    case "remove":
                        int countToRemoveFromStack = int.Parse(commandInformation[1]);

                        if (countToRemoveFromStack <= numbers.Count)
                        {
                            for (int i = 0; i < countToRemoveFromStack; i++)
                            {
                                numbers.Pop();
                            }
                        }
                        else
                        {
                            continue;
                        }

                        break;
                }
            }

            short sum = (short)numbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
