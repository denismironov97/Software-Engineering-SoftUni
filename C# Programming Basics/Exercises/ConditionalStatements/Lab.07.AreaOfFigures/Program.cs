using System;

namespace Lab._07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfGeometriFigure = Console.ReadLine();
            double sideOfSquare = 0;
            double lenghtOfRectangle = 0;
            double widthOfRectangle = 0;
            double radiusOfCircle = 0;
            double sideOfTriangle = 0;
            double heightOfTriangle = 0;

            if (typeOfGeometriFigure == "square")
            {
                sideOfSquare = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(sideOfSquare * sideOfSquare, 3));
            }
            else if (typeOfGeometriFigure == "rectangle")
            {
                lenghtOfRectangle = double.Parse(Console.ReadLine());
                widthOfRectangle = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(lenghtOfRectangle * widthOfRectangle, 3));
            }
            else if (typeOfGeometriFigure == "circle")
            {
                radiusOfCircle = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * (radiusOfCircle * radiusOfCircle), 3));
            }
            else if (typeOfGeometriFigure == "triangle")
            {
                sideOfTriangle = double.Parse(Console.ReadLine());
                heightOfTriangle = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((sideOfTriangle * heightOfTriangle / 2), 3));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
