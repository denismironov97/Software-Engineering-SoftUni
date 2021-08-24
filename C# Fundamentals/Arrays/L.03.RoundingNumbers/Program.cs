using System;

namespace L._03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] valuesString = values.Split();
            int lenght = valuesString.Length;
            double[] numArray = new double[lenght]; //
            for (int i = 0; i < lenght; i++)
            {
                numArray[i] = double.Parse(valuesString[i]);
            }

            foreach (double number in numArray)
            {
                int roundedNum = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", (decimal)number, (decimal)roundedNum);
            }

            //double number = 2.5; // normal rounding in general Math;
            //Console.WriteLine(Math.Round(number));
        }
    }
}
