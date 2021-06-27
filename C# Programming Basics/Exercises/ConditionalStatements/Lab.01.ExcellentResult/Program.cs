using System;

namespace Lab._01.ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputGrade = double.Parse(Console.ReadLine());
            
            if (inputGrade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
