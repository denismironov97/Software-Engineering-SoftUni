using System;

namespace L._02.GradesModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string result = GetGradeResult(num);
            Console.WriteLine(result);
        }
        static string GetGradeResult(double number)
        {
            if (number >= 2 && number <= 2.99)
            {
                return "Fail";
            }
            else if (number >= 3 && number <= 3.49)
            {
                return "Poor";
            }
            else if (number >= 3.5 & number <= 4.49)
            {
                return "Good";
            }
            else if (number >= 4.5 && number <= 5.49)
            {
                return "Very good";
            }
            else
            {
                return "Excellent";
            }
        }
    }
}
