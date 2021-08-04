using System;

namespace L._06.ForeignLangs
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string english = "English";
            string spanish = "Spanish";
            if (country == "USA" || country == "England")
            {
                Console.WriteLine("{0}", english);
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                Console.WriteLine("{0}", spanish);
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
