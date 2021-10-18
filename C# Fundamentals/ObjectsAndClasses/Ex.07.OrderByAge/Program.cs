using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> identificationPerson = new Dictionary<string, Person>();
            while (true)
            {
                string[] personDataParts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (personDataParts[0] == "End")
                {
                    break;
                }

                string name = personDataParts[0];
                string ID = personDataParts[1];
                int age = int.Parse(personDataParts[2]);

                if (!identificationPerson.ContainsKey(ID))
                {
                    identificationPerson.Add(ID, new Person(name, ID, age));
                }
                else
                {
                    identificationPerson[ID].Name = name;
                    identificationPerson[ID].Age = age;
                }
            }

            foreach (var kvp in identificationPerson.OrderBy(x => x.Value.Age))
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }

    class Person
    {
        public Person(string name, string ID, int age)
        {
            this.Name = name;
            this.Identification = ID;
            this.Age = age;
        }

        public string Name { get; set; }

        public string Identification { get; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Identification} is {this.Age} years old.";
        }
    }
}
