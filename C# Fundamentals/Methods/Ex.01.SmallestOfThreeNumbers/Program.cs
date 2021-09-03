using System;

namespace Ex._01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            GetMinNum(num1, num2, num3);
        }

        static void GetMinNum(int num1, int num2, int num3)
        {
            int minNum = 0;
            if (num1 < num2)
            {
                minNum = num1;
            }
            else // num1 >= num2
            {
                minNum = num2;
            }
            if (minNum > num3)
            {
                minNum = num3;
            }
            Console.WriteLine(minNum);
        }
    }
}
