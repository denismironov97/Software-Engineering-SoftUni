using System;

namespace Ex._01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine(); // Premiere = 12lv ; Normal = 7.50; Discount = 5.00;
            int numOfRows = int.Parse(Console.ReadLine());
            int numOfColons = int.Parse(Console.ReadLine());
            int numOfSeats = numOfRows * numOfColons;
            
            switch (typeOfProjection)
            {
                case "Premiere":
                    Console.WriteLine($"{(numOfSeats * 12):f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{(numOfSeats * 7.50):f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{(numOfSeats * 5.00):f2} leva");
                    break;
            }
        }
    }
}
