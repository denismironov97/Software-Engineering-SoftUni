using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentNameGradeInformation = new Dictionary<string, List<double>>();
            Dictionary<string, double> studentNameAverageGradeInformation = new Dictionary<string, double>();

            for (int i = 0; i < nLines; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                //List<double> grades = new List<double>();

                if (!studentNameGradeInformation.ContainsKey(studentName))
                {

                    studentNameGradeInformation.Add(studentName, new List<double>());
                    studentNameGradeInformation[studentName].Add(studentGrade);
                    studentNameAverageGradeInformation.Add(studentName, 0); //
                }
                else
                {
                    studentNameGradeInformation[studentName].Add(studentGrade);
                }
            }

            foreach (var kvp in studentNameGradeInformation)
            {
                List<double> gradesPerStudent = kvp.Value;
                double studentAverageGrade = gradesPerStudent.Average();

                studentNameAverageGradeInformation[kvp.Key] = studentAverageGrade;
            }

            Dictionary<string, double> sortedAverageGradesOfSudents = studentNameAverageGradeInformation.Where(x => x.Value >= 4.50).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedAverageGradesOfSudents)
            {
                Console.WriteLine("{0} -> {1:f2}", kvp.Key, kvp.Value);
            }
        }
    }
}
