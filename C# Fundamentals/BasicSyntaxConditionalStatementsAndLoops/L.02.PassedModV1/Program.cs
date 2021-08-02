using System;

namespace L._02.PassedModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = Convert.ToDouble(Console.ReadLine());
            
            bool passed = grade >= 3;
            switch (passed)
            {
                case true:
                    Console.WriteLine("Passed!");
                    break;
            }
        }
    }
}
