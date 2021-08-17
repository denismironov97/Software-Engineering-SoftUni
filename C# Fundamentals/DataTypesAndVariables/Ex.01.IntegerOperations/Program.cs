using System;

namespace Ex._01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            long sum = num1 + num2;
            long division = sum / num3;
            long multiplication = division * num4;
            Console.WriteLine(multiplication);
        }
    }
}
