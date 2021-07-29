using System;

namespace Ex._04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfJudges = int.Parse(Console.ReadLine()); //n
            string presentation = Console.ReadLine();
            double totalAverageGRadeSumOfStudent = 0;
            int numOfPresentations = 0;

            while (presentation != "Finish")
            {
                double inputGrade = 0;
                double sumOfInputGrades = 0;
                double averageGradeOfPresentation = 0;
                numOfPresentations++;
                for (int interator = 1; interator <= numOfJudges; interator++)
                {
                    inputGrade = double.Parse(Console.ReadLine());
                    sumOfInputGrades += inputGrade;
                }
                averageGradeOfPresentation = sumOfInputGrades / numOfJudges;
                totalAverageGRadeSumOfStudent += averageGradeOfPresentation; // sum of the average grades for each presentation;
                Console.WriteLine($"{presentation} - {averageGradeOfPresentation:f2}.");
                presentation = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {totalAverageGRadeSumOfStudent / numOfPresentations:f2}.");
        }
    }
}
