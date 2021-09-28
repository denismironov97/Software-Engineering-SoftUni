using System;
using System.Linq;
using System.Collections.Generic;

namespace L._05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); //list of objects
            string[] input = Console.ReadLine().Split();
            while (input[0] != "end")
            {
                string name = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string town = input[3];

                if (IsStudentExisting(students, name, lastName))
                {
                    Student student = GetStudent(students, name, lastName);

                    student.FirstName = name;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = town;
                }
                else
                {
                    Student student = new Student() //obj
                    {
                        FirstName = name,
                        LastName = lastName,
                        Age = age,
                        Hometown = town
                    };

                    students.Add(student);
                }

                input = Console.ReadLine().Split(); // slower operation than the one with the tokens!
            }
            string filterTown = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.Hometown == filterTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        private static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student exsistingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    exsistingStudent = student;
                }
            }

            return exsistingStudent;
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}

