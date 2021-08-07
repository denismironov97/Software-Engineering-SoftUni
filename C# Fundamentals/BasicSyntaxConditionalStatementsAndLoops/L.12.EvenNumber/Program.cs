using System;

namespace L._12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int inputNum = int.Parse(Console.ReadLine());
                if (inputNum % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(inputNum)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    continue;
                }
            }
        }
    }
}
