using System;

namespace L._12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte inputNum = byte.Parse(Console.ReadLine());
            ushort operationNum = 0;
            bool magicNum = false;
            for (ushort number = 1; number <= inputNum; number++)
            {
                int digitSum = 0; //
                operationNum = number;
                while (operationNum > 0)
                {
                    digitSum += operationNum % 10; // 
                    operationNum = (ushort)(operationNum / 10); //
                }
                magicNum = (digitSum == 5) || (digitSum == 7) || (digitSum == 11); //
                Console.WriteLine("{0} -> {1}", number, magicNum);
            }
        }
    }
}
