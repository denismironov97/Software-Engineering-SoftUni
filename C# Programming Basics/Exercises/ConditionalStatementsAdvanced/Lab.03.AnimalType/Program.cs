using System;

namespace Lab._03.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string animalType = "";
            
            switch (animal)
            {
                case "dog":
                    animalType = "mammal";
                    break;

                case "snake":
                case "crocodile":
                case "tortoise":
                    animalType = "reptile";
                    break;

                default:
                    animalType = "unknown";
                    break;
            }

            Console.WriteLine(animalType);
        }
    }
}
