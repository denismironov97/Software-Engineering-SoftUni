using System;

namespace Ex._05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = ""; // “Bulgaria"; "Balkans” ; ”Europe”;
            string typeOfVacation = "";  //„Camp” ; „Hotel”;
            double moneySpent = 0;
            
            switch (season)
            {
                case "summer":
                    typeOfVacation = "Camp";
                    break;
                case "winter":
                    typeOfVacation = "Hotel";
                    break;
            }
            if (budget <= 100)
            {
                destination = "Bulgaria";
                
                if (season == "summer")
                {
                    moneySpent = budget * 0.3;
                }
                else if (season == "winter")
                {
                    moneySpent = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                
                if (season == "summer")
                {
                    moneySpent = budget * 0.4;
                }
                else if (season == "winter")
                {
                    moneySpent = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                moneySpent = budget * 0.9;
                typeOfVacation = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {moneySpent:f2}");
        }
    }
}
