using System;

namespace L._01.StudentInfoV01
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
            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:f2}", studentName, age, averageGrade); // 3) Placeholders
        }
    }
}
