using System;

namespace Lab._06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthOfRactangleInputVal = double.Parse(Console.ReadLine());
            double lenghtOfRectangleInputVal = double.Parse(Console.ReadLine());
            double result = AreaOfRecktangle(widthOfRactangleInputVal, lenghtOfRectangleInputVal);
            Console.WriteLine(result);
        }
        static double AreaOfRecktangle(double widthOfRactangle, double lenghtOfRectangle)
        {
            return widthOfRactangle * lenghtOfRectangle;
        }
    }
}
