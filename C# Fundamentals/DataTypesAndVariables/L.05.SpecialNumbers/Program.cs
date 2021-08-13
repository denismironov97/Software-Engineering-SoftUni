using System;

namespace L._05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNum; i++)
            {
                int number = i;
                int digitSum = 0;
                bool magicNum = false;
                while (number > 0)
                {
                    digitSum += number % 10;
                    number /= 10; // number = number / 10;
                }
                if (digitSum == 5 || digitSum == 7 || digitSum == 11)
                {
                    magicNum = true;
                }
                Console.WriteLine($"{i} -> {magicNum}");
            }
        }
    }
}
