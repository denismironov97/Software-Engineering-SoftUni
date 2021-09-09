using System;

namespace Ex._08.FactorialDivisionModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            decimal result = FactorielDivision(nums[0], nums[1]);
            Console.WriteLine("{0:f2}", result);
        }

        private static decimal FactorielDivision(int num1, int num2)
        {
            long factoriel1 = 1;
            long factoriel2 = 1;
            for (int i = 1; i <= num1; i++)
            {
                factoriel1 *= i;
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
