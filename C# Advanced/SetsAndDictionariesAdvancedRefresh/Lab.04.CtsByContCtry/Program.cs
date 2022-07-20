using System;
using System.Collections.Generic;

namespace Lab._04.CtsByContCtry
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentsCountriesCities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < nLines; i++)
            {
                string[] informationParts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = informationParts[0];
                string country = informationParts[1];
                string city = informationParts[2];

                if (!continentsCountriesCities.ContainsKey(continent))
                {
                    continentsCountriesCities.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentsCountriesCities[continent].ContainsKey(country))
                {
                    continentsCountriesCities[continent].Add(country, new List<string>());
                }

                continentsCountriesCities[continent][country].Add(city);
            }

            foreach (var kvp in continentsCountriesCities)
            {
                string continent = kvp.Key;
                Console.WriteLine($"{continent}:");

                Dictionary<string, List<string>> countiesCities = kvp.Value;

                foreach (var kvpCountryCities in countiesCities)
                {
                    string country = kvpCountryCities.Key;
                    List<string> cities = kvpCountryCities.Value;

                    Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
                }
            }

            //Europe:
            //  Bulgaria->Sofia, Plovdiv
            //  Poland->Warsaw, Poznan
            //  Germany->Berlin

            //Asia:
            //  China->Beijing, Shanghai
            //  Japan->Tokyo
        }
    }
}
