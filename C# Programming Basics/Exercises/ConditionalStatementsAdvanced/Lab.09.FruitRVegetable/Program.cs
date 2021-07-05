using System;

namespace Lab._09.FruitRVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            bool fruit = food == "banana" || food == "apple" || food == "kiwi" || food == "cherry" || food == "lemon" || food == "grapes";
            bool vegetable = food == "tomato" || food == "cucumber" || food == "pepper" || food == "carrot";
            
            if (fruit)
            {
                Console.WriteLine("fruit");
            }
            else if (vegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
