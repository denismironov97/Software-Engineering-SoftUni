using System;

namespace Ex._03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPeople = int.Parse(Console.ReadLine());
            int capacityP = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling((double)nPeople / capacityP);
            Console.WriteLine(courses);
        }
    }
}
