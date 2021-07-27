using System;

namespace Ex._05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentOfHall = double.Parse(Console.ReadLine());
            double bCake = rentOfHall * 0.2;
            double drinks = bCake - bCake * 0.45; // = bCake * 0.55;
            double entartainer = rentOfHall / 3;
            double budget = rentOfHall + bCake + drinks + entartainer;
            Console.WriteLine(budget);

            //Торта  – цената ѝ е 20 % от наема на залата
            //Напитки – цената им е 45 % по - малко от тази на тортата
            //Аниматор – цената му е 1 / 3 от цената за наема на залата
        }
    }
}
