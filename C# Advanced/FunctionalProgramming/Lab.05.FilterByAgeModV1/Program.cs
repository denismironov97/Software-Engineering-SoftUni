using System;

namespace Lab._05.FilterByAgeModV1
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
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

            string condition = Console.ReadLine();//"younger" or "older"
            int ageFilter = int.Parse(Console.ReadLine());
            string formatType = Console.ReadLine();//"name", "age" or "name age"

            Func<Person, bool> conditionDelegate = GetCondition(condition, ageFilter);
            Action<Person> printerDelegate = GetFormat(formatType);

            foreach (Person person in people)
            {
                if (conditionDelegate(person))
                {
                    printerDelegate(person);
                }
            }
        }

        private static Func<Person, bool> GetCondition(string condition, int ageFilter)
        {
            switch (condition)
            {
                case "younger":
                    return p => p.Age < ageFilter;
                case "older":
                    return p => p.Age >= ageFilter;
                default:
                    return null;
            }
        }

        private static Action<Person> GetFormat(string formatType)
        {
            switch (formatType)
            {
                case "name":
                    return p =>
                    {
                        Console.WriteLine($"{p.Name}");
                    };
                case "age":
                    return p =>
                    {
                        Console.WriteLine($"{p.Age}");
                    };
                case "name age":
                    return p =>
                    {
                        Console.WriteLine($"{p.Name} - {p.Age}");
                    };
                default:
                    return null;
            }
        }
    }
}
