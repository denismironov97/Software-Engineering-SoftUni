using System;
using System.Collections.Generic;

namespace Lab._03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputDataInformation = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var storeProductPrice = new SortedDictionary<string, Dictionary<string, double>>();//storeBrand ->KVP[productType(key) productPrice(value)]

            while (inputDataInformation[0] != "Revision")
            {
                string storeBrand = inputDataInformation[0];
                string productType = inputDataInformation[1];
                double productPrice = double.Parse(inputDataInformation[2]);

                if (!storeProductPrice.ContainsKey(storeBrand))
                {
                    storeProductPrice.Add(storeBrand, new Dictionary<string, double>());
                }

                if (!storeProductPrice[storeBrand].ContainsKey(productType))
                {
                    storeProductPrice[storeBrand].Add(productType, productPrice);
                }
                else
                {
                    storeProductPrice[storeBrand][productType] = productPrice;
                }

                //storeProductPrice[storeBrand][productType] = productPrice;

                inputDataInformation = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in storeProductPrice)
            {
                string storeName = kvp.Key;
                Dictionary<string, double> typeProductPrice = kvp.Value;
                Console.WriteLine($"{storeName}->");

                foreach (var kvpOftypeProductPrice in typeProductPrice)
                {
                    Console.WriteLine($"Product: {kvpOftypeProductPrice.Key}, Price: {kvpOftypeProductPrice.Value}");
                }
            }
        }
    }
}
