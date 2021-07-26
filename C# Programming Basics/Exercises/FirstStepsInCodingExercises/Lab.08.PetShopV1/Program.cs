using System;

namespace Lab._08.PetShopV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfPetsOfNeighbor = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numberOfDogs * 2.50 + numberOfPetsOfNeighbor * 4} lv.");
        }
    }
}
