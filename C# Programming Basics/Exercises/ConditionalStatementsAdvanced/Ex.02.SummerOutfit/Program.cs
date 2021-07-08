using System;

namespace Ex._02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string day = Console.ReadLine(); //"Morning", "Afternoon", "Evening"
            bool cold = degrees >= 10 && degrees <= 18;
            bool semiWarm = degrees > 18 && degrees <= 24;
            bool warm = degrees >= 25;
            if (cold)
            {
                switch (day)
                {
                    case "Morning":
                        Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
            else if (semiWarm)
            {
                switch (day)
                {
                    case "Morning":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
            else if (warm)
            {
                switch (day)
                {
                    case "Morning":
                        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
        }
    }
}
