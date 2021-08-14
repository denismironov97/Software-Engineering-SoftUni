using System;

namespace L._08.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            uint populationOfTown = uint.Parse(Console.ReadLine());
            float areaOfTown = float.Parse(Console.ReadLine());
            Console.WriteLine($"Town {nameOfTown} has population of {populationOfTown} and area {areaOfTown} square km.");
        }
    }
}
