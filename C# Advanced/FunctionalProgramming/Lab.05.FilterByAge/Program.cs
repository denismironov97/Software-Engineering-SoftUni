using System;
using System.Linq;

namespace Lab._05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                people[i] = new Person()
                {
                    Name = name,
                    Age = age
                };
            }

            string ageCondition = Console.ReadLine();//"younger" or "older"
            int ageFilter = int.Parse(Console.ReadLine());
            string formatType = Console.ReadLine();//"name", "age" or "name age"

            Person[] filteredPeople = GetPeopleFilteredByAgeCondition(ageCondition, ageFilter, people);
            Action<string, Person[]> printFilteredPeopleDelegate = PrintFilteredPeople;
            printFilteredPeopleDelegate(formatType, filteredPeople);
        }

        private static Person[] GetPeopleFilteredByAgeCondition(string ageCondition, int ageFilter, Person[] people)
        {
            if (ageCondition == "younger")
            {
                return people.Where(x => x.Age < ageFilter).ToArray();
            }
            else
            {
                return people.Where(x => x.Age >= ageFilter).ToArray();
            }
        }

        private static void PrintFilteredPeople(string formatType, Person[] people)
        {
            if (formatType == "name")
            {
                foreach (Person person in people)
                {
                    Console.WriteLine($"{person.Name}");
                }
            }
            else if (formatType == "age")
            {
                foreach (Person person in people)
                {
                    Console.WriteLine($"{person.Age}");
                }
            }
            else if (formatType == "name age")
            {
                foreach (Person person in people)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
        }
    }

    internal class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
