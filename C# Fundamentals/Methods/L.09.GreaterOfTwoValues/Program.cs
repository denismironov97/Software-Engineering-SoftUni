using System;

namespace L._09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (dataType == "int")
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);
                int maxResult = GetMax(num1, num2);
                Console.WriteLine(maxResult);
            }
            else if (dataType == "char")
            {
                char symbol1 = char.Parse(input1);
                char symbol2 = char.Parse(input2);
                char maxResult = GetMax(symbol1, symbol2);
                Console.WriteLine(maxResult);
            }
            else if (dataType == "string")
            {
                string maxResult = GetMax(input1, input2);
                Console.WriteLine(maxResult);
            }
        }
        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
            // return Math.Max(num1, num2);
        }

        static char GetMax(char symbol1, char symbol2)
        {
            if (symbol1 > symbol2)
            {
                return symbol1;
            }
            else // symbol1 <= symbol2 
            {
                return symbol2;
            }
            // return Math.Max(symbol1, symbol2);
        }

        static string GetMax(string input1, string input2)
        {
            if (input1.CompareTo(input2) >= 0)
            {
                return input1;
            }
            else
            {
                return input2;
            }
        }
    }
}
