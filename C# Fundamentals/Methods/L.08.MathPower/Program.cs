using System;

namespace L._08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNum = double.Parse(Console.ReadLine());
            int inputPower = int.Parse(Console.ReadLine());
            double output = RaiseToPower(inputNum, inputPower);
            Console.WriteLine(output);
        }
        static double RaiseToPower(double number, int power)
        {
            double endResult = 1;
            for (int i = 0; i < power; i++)
            {
                endResult *= number;
            }
            return endResult;
        }
    }
}
