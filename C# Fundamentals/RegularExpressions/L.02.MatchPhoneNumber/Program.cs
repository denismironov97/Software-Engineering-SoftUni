using System;
using System.Text.RegularExpressions;

namespace L._02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+([359]+)([- ])2(\2)(\d{3})(\2)(\d{4})\b";
            string phonesInputs = Console.ReadLine();
            Regex phonePatternex = new Regex(pattern);
            MatchCollection match = phonePatternex.Matches(phonesInputs);
            int phoneNumbersCount = 0;

            foreach (var phoneNumber in match)
            {
                string collection = phoneNumber + ", ";
                phoneNumbersCount += 1;
                if (phoneNumbersCount == match.Count)
                {
                    Console.Write(collection.Remove(collection.Length - 2));
                }
                else
                {
                    Console.Write(collection);
                }
            }
            Console.WriteLine();
        }
    }
}
