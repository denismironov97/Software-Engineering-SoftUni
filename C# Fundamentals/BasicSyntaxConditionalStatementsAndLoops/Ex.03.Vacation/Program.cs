using System;

namespace Ex._03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeopleInGroup = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double pricePerPerson = 0;
            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.9;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.6;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50;
                            break;
                    }
                    break;
            }
            double totalPrice = numOfPeopleInGroup * pricePerPerson;
            if (typeOfGroup == "Students" && numOfPeopleInGroup >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (typeOfGroup == "Business" && numOfPeopleInGroup >= 100)
            {
                totalPrice = (numOfPeopleInGroup - 10) * pricePerPerson;
            }
            else if (typeOfGroup == "Regular" && (numOfPeopleInGroup >= 10 && numOfPeopleInGroup <= 20))
            {
                totalPrice *= 0.95;//
            }
            Console.WriteLine("Total price: {0:f2}", totalPrice);
        }
    }
}
