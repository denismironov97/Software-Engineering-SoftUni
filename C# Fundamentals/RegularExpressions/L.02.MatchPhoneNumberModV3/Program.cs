using System;
using System.Text.RegularExpressions;

namespace L._02.MatchPhoneNumberModV3
{
    class Program
    {
        static void Main(string[] args)
        {
            string telephoneNumbers = Console.ReadLine();
            string pattern = @"\+([359]+)([- ])2(\2)(\d{3})(\2)(\d{4})\b";

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(telephoneNumbers);

            Console.WriteLine(string.Join(", ", matchCollection));
        }
    }
}
