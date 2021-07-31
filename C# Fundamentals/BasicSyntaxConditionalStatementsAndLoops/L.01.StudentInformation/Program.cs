using System;

namespace L._01.StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Name: {student name}, Age: {student age}, Grade: {student grade}"
            //Name: John, Age: 15, Grade: 5.40
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            Console.Write("Name: " + studentName + ", " + "Age: " + age + ", " + "Grade: ");
            Console.WriteLine($"{averageGrade:f2}");
        }
    }
}
