using System;

namespace Ex._08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            decimal result = FactorielDivision(num1, num2);
            Console.WriteLine("{0:f2}", result);
        }

        static decimal FactorielDivision(int num1, int num2)
        {
            long factoriel1 = 1;
            long factoriel2 = 1;
            for (int i = 1; i <= num1; i++)
            {
                factoriel1 = factoriel1 * i;
            }
            for (int i = 1; i <= num2; i++)
            {
                factoriel2 *= i;
            }
            decimal result = factoriel1 * 1.0M / factoriel2;
            return result;
        }
    }
}
