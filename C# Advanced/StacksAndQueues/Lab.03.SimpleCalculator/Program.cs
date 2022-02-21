using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputToCalc = Console.ReadLine().Split();
            Stack<string> calcData = new Stack<string>(inputToCalc.Reverse());

            while (calcData.Count > 1)
            {
                int num1 = int.Parse(calcData.Pop());
                char symbol = char.Parse(calcData.Pop());
                int num2 = int.Parse(calcData.Pop());

                int tempResult = 0;

                if (symbol == '+')
                {
                    tempResult = num1 + num2;
                }
                else
                {
                    tempResult = num1 - num2;
                }

                calcData.Push(tempResult.ToString());
            }

            Console.WriteLine(calcData.Pop());
        }
    }
}
