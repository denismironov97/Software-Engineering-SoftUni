using System;
using System.Collections.Generic;

namespace Lab._06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = "";
            Queue<string> supermarketClients = new Queue<string>();

            while ((inputName = Console.ReadLine()) != "End")
            {
                if (inputName == "Paid")
                {
                    foreach (string name in supermarketClients)
                    {
                        Console.WriteLine(name);
                    }

                    supermarketClients.Clear();
                    supermarketClients.TrimExcess();
                    continue;
                }

                supermarketClients.Enqueue(inputName);
            }

            Console.WriteLine($"{supermarketClients.Count} people remaining.");
        }
    }
}
