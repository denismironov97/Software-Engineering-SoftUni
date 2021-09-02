using System;

namespace L._08.MathPowerModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            double output = RaiseToPower(number: double.Parse(Console.ReadLine()), power: int.Parse(Console.ReadLine()));
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
