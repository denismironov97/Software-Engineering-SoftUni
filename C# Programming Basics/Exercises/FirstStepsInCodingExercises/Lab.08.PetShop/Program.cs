using System;

namespace Lab._08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfPetsOfNeighbor = int.Parse(Console.ReadLine());
            double priceOfFoodForDogs = 2.50;
            int priceOfFoodForNeighborPets = 4;
            double totalCostOfFood = numberOfDogs * priceOfFoodForDogs + numberOfPetsOfNeighbor * priceOfFoodForNeighborPets;
            Console.WriteLine($"{totalCostOfFood} lv.");
        }
    }
}
