using System;

namespace Ex._03.ElevatorModV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPeople = int.Parse(Console.ReadLine());
            int capacityP = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling(nPeople * 1.0 / capacityP);
            Console.WriteLine(courses);
        }
    }
}
