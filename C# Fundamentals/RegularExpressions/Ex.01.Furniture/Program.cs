using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex._01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            // ">>{furniture name}<<{price}!{quantity}"
            //string pattern = @">>[A-Za-z]+<<((\d+\.\d+)|(\d+))!\d+";
            string pattern = @">>([A-Za-z]+)<<((\d+\.\d+)|(\d+))!(\d+)";
            Regex regex = new Regex(pattern);

            string furnitureData = string.Empty;
            double totalPriceOfFurnitureAll = 0;
            List<string> furniture = new List<string>();

            while ((furnitureData = Console.ReadLine()) != "Purchase")
            {
                Match furnitureInformation = regex.Match(furnitureData);

                if (furnitureInformation.Success)
                {
                    string furnitureName = furnitureInformation.Groups[1].Value;
                    double price = double.Parse(furnitureInformation.Groups[2].Value);
                    int quantity = int.Parse(furnitureInformation.Groups[5].Value);
                    totalPriceOfFurnitureAll = totalPriceOfFurnitureAll + (price * quantity);
                    furniture.Add(furnitureName);
                }
            }

            Console.WriteLine($"Bought furniture:");

            foreach (string product in furniture)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine($"Total money spend: {totalPriceOfFurnitureAll:f2}");
        }
    }
}
