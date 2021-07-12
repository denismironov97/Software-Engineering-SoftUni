using System;

namespace Lab._08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue; // 100
            int biggest = int.MinValue; // -100
            
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < smallest) // max value (100)
                {
                    smallest = number;
                }
                if (number > biggest) // min value (-100)
                {
                    biggest = number;
                }
            }

            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
