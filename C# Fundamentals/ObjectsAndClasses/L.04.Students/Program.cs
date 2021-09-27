using System;
using System.Linq;
using System.Collections.Generic;

namespace L._04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }

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

                Student student = new Student() // obj
                {
                    FirstName = name,
                    LastName = lastName,
                    Age = age,
                    Hometown = town
                };

                students.Add(student);
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
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
    }
}
