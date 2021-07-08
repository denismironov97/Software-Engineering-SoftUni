using System;

namespace Lab._13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();
            int nightsOfStay = daysOfStay - 1;
            double priceForOnePerson = 18;
            double priceForApartment = 25;
            double priceForPresidentApartment = 35;
            double priceOfStay = 0;
            
            if (nightsOfStay < 9)
            {
                if (typeOfRoom == "room for one person")
                {
                    priceOfStay = nightsOfStay * priceForOnePerson;
                }
                else if (typeOfRoom == "apartment")
                {
                    priceOfStay = nightsOfStay * priceForApartment * 0.70; // 30% discount
                }
                else if (typeOfRoom == "president apartment")
                {
                    priceOfStay = nightsOfStay * priceForPresidentApartment * 0.90;
                }
            }
            else if (nightsOfStay >= 9 && nightsOfStay <= 14)
            {
                if (typeOfRoom == "room for one person")
                {
                    priceOfStay = nightsOfStay * priceForOnePerson;
                }
                else if (typeOfRoom == "apartment")
                {
                    priceOfStay = nightsOfStay * priceForApartment * 0.65; // 35% discount
                }
                else if (typeOfRoom == "president apartment")
                {
                    priceOfStay = nightsOfStay * priceForPresidentApartment * 0.85; // 15% discount
                }
            }
            else //(nightsOfStay > 14)
            {
                if (typeOfRoom == "room for one person")
                {
                    priceOfStay = nightsOfStay * priceForOnePerson;
                }
                else if (typeOfRoom == "apartment")
                {
                    priceOfStay = nightsOfStay * priceForApartment * 0.50; // 50% discount
                }
                else if (typeOfRoom == "president apartment")
                {
                    priceOfStay = nightsOfStay * priceForPresidentApartment * 0.80; // 20% discount
                }
            }
            if (grade == "positive")
            {
                priceOfStay = priceOfStay * 1.25;
            }
            else
            {
                priceOfStay = priceOfStay * 0.90; // 10% discount
            }
            Console.WriteLine($"{priceOfStay:f2}");
        }
    }
}
