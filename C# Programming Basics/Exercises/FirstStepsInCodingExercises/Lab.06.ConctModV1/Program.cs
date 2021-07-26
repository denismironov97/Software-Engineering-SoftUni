using System;

namespace Lab._06.ConctModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string familyName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {familyName}, a {age}-years old person from {town}.");
        }
    }
}
