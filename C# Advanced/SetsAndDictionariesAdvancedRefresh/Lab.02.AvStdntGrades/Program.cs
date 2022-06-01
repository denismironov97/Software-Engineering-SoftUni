using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._02.AvStdntGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLinesInput = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentNameGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < nLinesInput; i++)
            {
                string[] studentData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string studentName = studentData[0];
                decimal grade = decimal.Parse(studentData[1]);

                if (!studentNameGrades.ContainsKey(studentName))
                {
                    studentNameGrades.Add(studentName, new List<decimal>());
                }

                studentNameGrades[studentName].Add(grade);
            }

            //Stamat -> 2.00 3.00 (avg: 2.50)

            foreach (var kvp in studentNameGrades)
            {
                string name = kvp.Key;
                List<decimal> gradesOfStudent = kvp.Value;

                Console.Write($"{name} -> ");

                foreach (decimal grade in gradesOfStudent)
                {
                    Console.Write($"{grade:f2} ");
                }

                decimal averageGrade = gradesOfStudent.Average();
                Console.WriteLine($"(avg: {averageGrade:f2})");
            }
        }
    }
}
