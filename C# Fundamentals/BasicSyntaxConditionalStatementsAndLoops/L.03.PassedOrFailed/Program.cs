using System;

namespace L._03.PassedOrFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            
            bool passed = grade >= 3;
            switch (passed)
            {
                case true:
                    Console.WriteLine("Passed!");
                    break;
                default:
                    Console.WriteLine("Failed!");
                    break;
            }
        }
    }
}
