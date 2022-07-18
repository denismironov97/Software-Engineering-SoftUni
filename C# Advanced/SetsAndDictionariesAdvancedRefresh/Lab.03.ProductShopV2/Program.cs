using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._03.ProductShopV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> storeBrandProductTypePrice = new Dictionary<string, Dictionary<string, double>>();
            string[] informationData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (informationData[0] != "Revision")
            {
                string storeBrand = informationData[0];
                string product = informationData[1];
                double productPrice = double.Parse(informationData[2]);

                if (!storeBrandProductTypePrice.ContainsKey(storeBrand))
                {
                    storeBrandProductTypePrice.Add(storeBrand, new Dictionary<string, double>());
                }

                if (!storeBrandProductTypePrice[storeBrand].ContainsKey(product))
                {
                    storeBrandProductTypePrice[storeBrand].Add(product, productPrice);
                }
                else
                {
                    storeBrandProductTypePrice[storeBrand][product] = productPrice;
                }

                informationData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            //fantastico->
            //Product: apple, Price: 1.2
            //Product: grape, Price: 2.2

            storeBrandProductTypePrice = storeBrandProductTypePrice.OrderBy(kvp => kvp.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvpStoreProductPrice in storeBrandProductTypePrice)
            {
                string storeName = kvpStoreProductPrice.Key;
                Console.WriteLine($"{storeName}->");

                Dictionary<string, double> productPrice = kvpStoreProductPrice.Value;

                foreach (var kvpProductPrice in productPrice)
                {
                    Console.WriteLine($"Product: {kvpProductPrice.Key}, Price: {kvpProductPrice.Value}");
                }
            }
        }
    }
}
