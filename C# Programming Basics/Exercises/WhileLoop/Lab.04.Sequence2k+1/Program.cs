using System;

namespace Lab._04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNum = double.Parse(Console.ReadLine());
            double operationNum = 1;
            
            while (operationNum <= inputNum)
            {
                Console.WriteLine(operationNum);
                operationNum = operationNum * 2 + 1;
            }
            
            //double inputNum = double.Parse(Console.ReadLine()); // 31
            //double num = 1;
            
            //while (true)
            //{
            //    Console.WriteLine(num);
            //    num = num * 2 + 1;
                
            //    if (num == inputNum)
            //    {
            //        Console.WriteLine(num);
            //        break;
            //    }
            //    else if (num > inputNum)
            //    {
            //        break;
            //    }
            //}
        }
    }
}
