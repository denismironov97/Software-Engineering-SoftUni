using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace L._02.MatchPhoneNumberModV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();
            string pattern = @"\+([359]+)([- ])2(\2)(\d{3})(\2)(\d{4})\b";
            string pattern1 = @"\+[359]+([- ])2\1\d{3}\1\d{4}\b";
            MatchCollection phoneMatches = Regex.Matches(phones, pattern1);
            string[] matchPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchPhones));
        }
    }
}
