using System;

namespace Ex._03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceOfRose = 5;
            double priceOfDahlia = 3.80;
            double priceOfTulip = 2.80;
            double priceOfNarcissus = 3;
            double priceOfGladiolus = 2.50;
            double totalPrice = 0;

            if (typeOfFlower == "Roses")
            {
                if (numOfFlowers > 80)
                {
                    totalPrice = 0.9 * (priceOfRose * numOfFlowers); //discounted whole price
                }
                else
                {
                    totalPrice = priceOfRose * numOfFlowers;
                }

            }
            else if (typeOfFlower == "Dahlias")
            {
                if (numOfFlowers > 90)
                {
                    totalPrice = 0.85 * (priceOfDahlia * numOfFlowers);
                }
                else
                {
                    totalPrice = priceOfDahlia * numOfFlowers;
                }
            }
            else if (typeOfFlower == "Tulips")
            {
                if (numOfFlowers > 80)
                {
                    totalPrice = 0.85 * (priceOfTulip * numOfFlowers);
                }
                else
                {
                    totalPrice = priceOfTulip * numOfFlowers;
                }
            }
            else if (typeOfFlower == "Narcissus")
            {
                if (numOfFlowers < 120) 
                {
                    totalPrice = 1.15 * (priceOfNarcissus * numOfFlowers);
                }
                else
                {
                    totalPrice = priceOfNarcissus * numOfFlowers;
                }
            }
            else if (typeOfFlower == "Gladiolus")
            {
                if (numOfFlowers < 80) 
                {
                    totalPrice = 1.2 * (priceOfGladiolus * numOfFlowers);
                }
                else
                {
                    totalPrice = priceOfGladiolus * numOfFlowers;
                }
            }

            //Console.WriteLine(totalPrice);
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {typeOfFlower} and {(budget - totalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");
            }
        }
    }
}
