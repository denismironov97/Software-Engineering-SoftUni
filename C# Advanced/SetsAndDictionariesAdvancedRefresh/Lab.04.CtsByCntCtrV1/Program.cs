using System;
using System.Collections.Generic;

namespace Lab._04.CtsByCntCtrV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> continentCountry = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> countryCities = new Dictionary<string, List<string>>();

            for (int i = 0; i < nLines; i++)
            {
                string[] informationParts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = informationParts[0];
                string country = informationParts[1];
                string city = informationParts[2];

                if (!continentCountry.ContainsKey(continent))
                {
                    continentCountry.Add(continent, new List<string>());
                }

                if (!continentCountry[continent].Contains(country))
                {
                    continentCountry[continent].Add(country);
                }

                if (!countryCities.ContainsKey(country))
                {
                    countryCities.Add(country, new List<string>());
                    countryCities[country].Add(city);
                }
                else
                {
                    countryCities[country].Add(city);
                }
            }

            foreach (var kvp in continentCountry)
            {
                string continent = kvp.Key;
                List<string> countries = kvp.Value;
                Console.WriteLine($"{continent}:");

                foreach (string country in countries)
                {
                    foreach (var kvpCountryCities in countryCities)
                    {
                        string countryKey = kvpCountryCities.Key;
                        List<string> cities = kvpCountryCities.Value;

                        if (country == countryKey)
                        {
                            Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
                            break;
                        }
                    }
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
