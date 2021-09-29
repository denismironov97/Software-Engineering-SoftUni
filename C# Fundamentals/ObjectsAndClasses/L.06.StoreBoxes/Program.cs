using System;
using System.Linq;
using System.Collections.Generic;

namespace L._06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] informationParts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string serialNum = informationParts[0];
                string itemName = informationParts[1];
                int itemQuantity = int.Parse(informationParts[2]);
                decimal itemPrice = decimal.Parse(informationParts[3]);

                Item currItem = new Item();
                currItem.Name = itemName;
                currItem.Price = itemPrice;

                Box currBox = new Box();
                currBox.SerialNumber = serialNum;
                currBox.Item = currItem;
                currBox.ItemQuantity = itemQuantity;
                currBox.PricePerBox = currBox.ItemQuantity * currBox.Item.Price;

                boxes.Add(currBox);
                command = Console.ReadLine();
            }

            foreach (var currBox in boxes.OrderByDescending(box => box.PricePerBox))
            {
                Console.WriteLine(currBox.SerialNumber);
                Console.WriteLine($"-- {currBox.Item.Name} - ${currBox.Item.Price:f2}: {currBox.ItemQuantity}");
                Console.WriteLine($"-- ${currBox.PricePerBox:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PricePerBox { get; set; }
    }
}
