using System;
using System.Collections.Generic;
namespace L._04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }

            products.Sort(); // sorts the list (currently in alphabetical order);

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, products[i]);
            }
        }
    }
}
