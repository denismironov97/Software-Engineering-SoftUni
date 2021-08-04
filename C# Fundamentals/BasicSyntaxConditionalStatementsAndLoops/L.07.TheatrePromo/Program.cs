using System;

namespace L._07.TheatrePromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine()); //0 <= age <= 18; 18 < age <= 64; 64 < age <= 122
            int priceOfTicket = 0;
            if (age >= 0 && age <= 18)
            {
                if (typeOfDay == "Weekday")
                {
                    priceOfTicket = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    priceOfTicket = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    priceOfTicket = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    priceOfTicket = 18;
                }
                else if (typeOfDay == "Weekend")
                {
                    priceOfTicket = 20;
                }
                else if (typeOfDay == "Holiday")
                {
                    priceOfTicket = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    priceOfTicket = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    priceOfTicket = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    priceOfTicket = 10;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                Environment.Exit(0);
            }
            Console.WriteLine($"{priceOfTicket}$");
        }
    }
}
