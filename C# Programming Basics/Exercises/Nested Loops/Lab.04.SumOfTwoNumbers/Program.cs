using System;

namespace Lab._04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begingOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;
            int combinations = 0;
            bool isMagicNumberFound = false;

            for (number1 = begingOfInterval; number1 <= endOfInterval; number1++)
            {
                for (number2 = begingOfInterval; number2 <= endOfInterval; number2++)
                {
                    combinations++;

                    if (number1 + number2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({number1} + {number2} = {magicNumber})");
                        isMagicNumberFound = true;
                        break;
                    }
                }

                if (isMagicNumberFound)
                {
                    break;
                }
            }

            if (!isMagicNumberFound) // (isMagicNumberFound != true) (isMagicNumberFound == false)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
