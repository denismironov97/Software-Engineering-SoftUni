using System;

namespace Lab._05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            double sum = 0;
            
            while (inputNumber != "NoMoreMoney")
            {
                double currentNum = double.Parse(inputNumber);
                
                if (currentNum >= 0)
                {
                    Console.WriteLine($"Increase: {currentNum:f2}");
                    sum = sum + currentNum;
                    inputNumber = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
