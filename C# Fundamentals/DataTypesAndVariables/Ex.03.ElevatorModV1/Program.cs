using System;

namespace Ex._03.ElevatorModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPeople = int.Parse(Console.ReadLine());
            int capacityP = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling(nPeople / (double)capacityP);
            Console.WriteLine(courses);
        }
    }
}
