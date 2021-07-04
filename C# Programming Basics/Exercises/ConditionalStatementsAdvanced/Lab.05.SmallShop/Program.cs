using System;

namespace Lab._05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            
            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(quantity * 0.5);
                        break;
                    case "water":
                        Console.WriteLine(quantity * 0.8);
                        break;
                    case "beer":
                        Console.WriteLine(quantity * 1.2);
                        break;
                    case "sweets":
                        Console.WriteLine(quantity * 1.45);
                        break;
                    case "peanuts":
                        Console.WriteLine(quantity * 1.6);
                        break;
                }
            }
            else if (town == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(quantity * 0.4);
                        break;
                    case "water":
                        Console.WriteLine(quantity * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(quantity * 1.15);
                        break;
                    case "sweets":
                        Console.WriteLine(quantity * 1.3);
                        break;
                    case "peanuts":
                        Console.WriteLine(quantity * 1.5);
                        break;
                }
            }
            else if (town == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(quantity * 0.45);
                        break;
                    case "water":
                        Console.WriteLine(quantity * 0.7);
                        break;
                    case "beer":
                        Console.WriteLine(quantity * 1.1);
                        break;
                    case "sweets":
                        Console.WriteLine(quantity * 1.35);
                        break;
                    case "peanuts":
                        Console.WriteLine(quantity * 1.55);
                        break;
                }
            }
        }
    }
}
