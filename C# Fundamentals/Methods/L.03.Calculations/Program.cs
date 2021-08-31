using System;

namespace L._03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            if (action == "add")
            {
                Аddition(num1, num2);
            }
            else if (action == "subtract")
            {
                //Subtraction(number1: double.Parse(Console.ReadLine()), number2: double.Parse(Console.ReadLine()));
                Subtraction(number1: num1, number2: num2);
            }
            else if (action == "multiply")
            {
                //Multiplication(number2: double.Parse(Console.ReadLine()), number1: double.Parse(Console.ReadLine()));
                Multiplication(num1, num2);
            }
            else //divide
            {
                Division(num1, num2);
            }
        }

        static void Аddition(double number1, double number2)
        {
            double endResult = number1 + number2;
            Console.WriteLine(endResult);
        }
        static void Subtraction(double number1, double number2)
        {
            double endResult = number1 - number2;
            Console.WriteLine(endResult);
        }
        static void Multiplication(double number1, double number2)
        {
            double endResult = number1 * number2;
            Console.WriteLine(endResult);
        }
        static void Division(double number1, double number2)
        {
            double endResult = number1 / number2;
            Console.WriteLine(endResult);
        }
    }
}
