using System;

namespace L._11.Mul_nTable_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product = 0;
            if (multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", inputNumber, multiplier, inputNumber * multiplier);
                Environment.Exit(0);
            }
            for (int beginingPointOfIterations = multiplier; beginingPointOfIterations <= 10; beginingPointOfIterations++)
            {
                product = inputNumber * multiplier;
                Console.WriteLine("{0} X {1} = {2}", inputNumber, multiplier, product);
                multiplier += 1;
            }
        }
    }
}
