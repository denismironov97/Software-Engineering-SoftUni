using System;

namespace L._02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            GetGRades(number);
        }
        static void GetGRades(double number)
        {
            if (number >= 2 && number <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (number >= 3 && number <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (number >= 3.5 & number <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (number >= 4.5 && number <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (number >= 5.5 && number <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
