using System;

namespace Ex._06.Ope_sBetweenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char symbolForOperations = char.Parse(Console.ReadLine());
            int result = 0;
            bool evenOrOdd = symbolForOperations == '+' || symbolForOperations == '-' || symbolForOperations == '*';
            
            if (evenOrOdd)
            {
                if (symbolForOperations == '+')
                {
                    result = num1 + num2;

                }
                else if (symbolForOperations == '-')
                {
                    result = num1 - num2;
                }
                else // *
                {
                    result = num1 * num2;
                }
                
                int evenOrNot = result % 2;
                string oddOrEven = "";
                
                if (evenOrNot == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }

                Console.WriteLine($"{num1} {symbolForOperations} {num2} = {result} - {oddOrEven}");
            }
            else if (symbolForOperations == '/' && num2 != 0)
            {
                Console.WriteLine($"{num1} {symbolForOperations} {num2} = {(num1 * 1.0 / num2):f2}");
            }
            else if (symbolForOperations == '%' && num2 != 0)
            {
                Console.WriteLine($"{num1} {symbolForOperations} {num2} = {num1 % num2}");
            }
            else
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
        }
    }
}
