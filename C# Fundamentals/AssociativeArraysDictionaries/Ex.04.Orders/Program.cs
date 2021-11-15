using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(' ');
            Dictionary<string, double> productByPrice = new Dictionary<string, double>(); // shared Dictionary
            Dictionary<string, int> productByQuantity = new Dictionary<string, int>(); // shared Dictionary

            while (inputData[0] != "buy")
            {
                string productName = inputData[0];
                double productPrice = double.Parse(inputData[1]);
                int productQuantity = int.Parse(inputData[2]);

                if (!productByPrice.ContainsKey(productName))
                {
                    productByPrice.Add(productName, productPrice);
                    productByQuantity.Add(productName, productQuantity);
                }
                else
                {
                    productByPrice[productName] = productPrice; // important
                    productByQuantity[productName] += productQuantity;
                }

                inputData = Console.ReadLine().Split(' ');
            }

            foreach (var kvp in productByPrice)
            {
                string nameOfProduct = kvp.Key;
                double priceOfProduct = kvp.Value;
                int quantityOfProduct = productByQuantity[nameOfProduct]; // with the same key gives the int value
                double totalPrice = priceOfProduct * quantityOfProduct;
                Console.WriteLine($"{nameOfProduct} -> {totalPrice:f2}");
            }
        }
    }
}
