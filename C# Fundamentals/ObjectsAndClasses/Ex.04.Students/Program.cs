using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < nLines; i++)
            {
                string[] studentData = Console.ReadLine().Split();
                string fistName = studentData[0];
                string lastName = studentData[1];
                float grade = float.Parse(studentData[2]);

                var student = new Student(fistName, lastName, grade);

                students.Add(student);
            }

            students = students.OrderByDescending(s => s.Grade).ToList();
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }
    }

    public class Student
    {
        public Student(string fistName, string lastName, float grade)
        {
            this.FirstName = fistName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }

    }
}
