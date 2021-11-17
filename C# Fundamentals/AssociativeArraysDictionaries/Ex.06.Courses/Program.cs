using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = string.Empty;
            Dictionary<string, List<string>> coursesAndStudentsData = new Dictionary<string, List<string>>(); // review objects and classes basics 

            while ((inputData = Console.ReadLine()) != "end")
            {
                string[] commandData = inputData.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = commandData[0];
                string studentName = commandData[1];
                List<string> students = new List<string>();

                if (!coursesAndStudentsData.ContainsKey(courseName))
                {
                    students.Add(studentName);
                    coursesAndStudentsData.Add(courseName, students);
                }
                else
                {
                    coursesAndStudentsData[courseName].Add(studentName);
                }
            }

            Dictionary<string, List<string>> sortedDictionary = coursesAndStudentsData.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value); // what's this?

            foreach (var kvp in sortedDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                // Console.WriteLine($"--{string.Join(Environment.NewLine, kvp.Value)}"); // how to make it without using the cyckle

                kvp.Value.Sort();

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
