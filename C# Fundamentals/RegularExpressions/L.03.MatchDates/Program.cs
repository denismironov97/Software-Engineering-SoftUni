using System;
using System.Text.RegularExpressions;

namespace L._03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(\d{2})([.\/-])([A-Z][a-z]{2})\2(\d{4})\b";
            string datesString = Console.ReadLine();

            MatchCollection dates = Regex.Matches(datesString, pattern);

            foreach (Match date in dates)
            {
                string day = date.Groups[1].Value;
                string month = date.Groups[3].Value;
                string year = date.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
