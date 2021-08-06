using System;

namespace L._10.Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int multiplier = 10;
            for (int iterations = 1; iterations <= multiplier; iterations++)
            {
                Console.WriteLine($"{inputNumber} X {iterations} = {inputNumber * iterations}");
            }
        }
    }
}
