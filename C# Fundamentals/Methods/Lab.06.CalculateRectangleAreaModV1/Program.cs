using System;

namespace Lab._06.CalculateRectangleAreaModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthOfRactangle = double.Parse(Console.ReadLine());
            double lenghtOfRectangle = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfRecktangle(widthOfRactangle, lenghtOfRectangle));
        }
        static double AreaOfRecktangle(double widthOfRactangle, double lenghtOfRectangle)
        {
            double areaOfRectangle = widthOfRactangle * lenghtOfRectangle;
            return areaOfRectangle;
        }
    }
}
