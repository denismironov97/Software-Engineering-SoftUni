using System;

namespace Ex._02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfUndesirableGradesTreshold = int.Parse(Console.ReadLine());
            string nameOfExercise = Console.ReadLine();
            string lastProblem = "";
            int counterForUndesirableGrades = 0;
            int counterForDesirableGrades = 0;
            int sumOfDesirableGrades = 0;
            int sumOfUndesirableGrades = 0;
            int counterForAllExercises = 0;
            int currentGrade = 0;

            while (nameOfExercise != "Enough")
            {
                lastProblem = nameOfExercise;
                counterForAllExercises++;
                currentGrade = int.Parse(Console.ReadLine());

                if (currentGrade > 4) // desirable grade
                {
                    counterForDesirableGrades++;
                    sumOfDesirableGrades += currentGrade;
                }
                else // undesirable grade 
                {
                    counterForUndesirableGrades++;
                    sumOfUndesirableGrades = sumOfUndesirableGrades + currentGrade;
                }

                if (counterForUndesirableGrades == numOfUndesirableGradesTreshold)
                {
                    Console.WriteLine($"You need a break, {counterForUndesirableGrades} poor grades.");
                    break;
                }
                nameOfExercise = Console.ReadLine();
            }

            if (nameOfExercise == "Enough")
            {
                Console.WriteLine($"Average score: {(sumOfDesirableGrades + sumOfUndesirableGrades) * 1.0 / (counterForDesirableGrades + counterForUndesirableGrades):f2}"); // + sumofundesirable
                Console.WriteLine($"Number of problems: {counterForAllExercises}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
