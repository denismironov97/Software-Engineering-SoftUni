using System;
using System.Text.RegularExpressions;

namespace Ex._03.SoftUniBarIncomeModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            Regex regex = new Regex(pattern);
            double totalIncome = 0;

            //Dictionary<string, Dictionary<string, double>> foo = new Dictionary<string, Dictionary<string, double>>();
            // 2 shared Dictionary's or just with 1
            // Dictionary< string, object>
            // Object

            while (true)
            {
                string orderData = Console.ReadLine();

                if (orderData == "end of shift")
                {
                    break;
                }
                else if (Regex.IsMatch(orderData, pattern))
                {
                    Match match = Regex.Match(orderData, pattern);
                    var customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double money = price * count;
                    Console.WriteLine($"{customer}: {product} - {money:F2}");
                    totalIncome += money;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
