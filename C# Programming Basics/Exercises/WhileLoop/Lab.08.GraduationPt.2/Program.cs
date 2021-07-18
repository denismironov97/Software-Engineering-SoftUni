using System;

namespace Lab._08.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            double grade = 0;
            double sumOfGrades = 0;
            int gradeCounter = 0;
            
            while (gradeCounter < 12)
            {
                grade = double.Parse(Console.ReadLine());
                gradeCounter++;
                
                if (grade < 4) // excluded
                {
                    Console.WriteLine($"{nameOfStudent} has been excluded at {gradeCounter} grade");
                    break;
                }

                sumOfGrades += grade;
            }

            if (gradeCounter >= 11)
            {
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {(sumOfGrades / gradeCounter):f2}");
            }
        }
    }
}
