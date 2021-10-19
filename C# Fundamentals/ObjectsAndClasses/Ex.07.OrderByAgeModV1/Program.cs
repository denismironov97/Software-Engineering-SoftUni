using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._07.OrderByAgeModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> identificationPerson = new Dictionary<string, Person>();
            while (true)
            {
                string[] personDataParts = Console.ReadLine().Split();

                if (personDataParts[0] == "End")
                {
                    break;
                }

                var personData = (personDataParts[0], personDataParts[1], int.Parse(personDataParts[2]));//Custom Tuple Value composition of three 

                if (!identificationPerson.ContainsKey(personData.Item2))
                {
                    identificationPerson.Add(personData.Item2, new Person(personData.Item1, personData.Item2, personData.Item3));
                }
                else
                {
                    identificationPerson[personData.Item2].Name = personData.Item2;
                    identificationPerson[personData.Item2].Age = personData.Item3;
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
