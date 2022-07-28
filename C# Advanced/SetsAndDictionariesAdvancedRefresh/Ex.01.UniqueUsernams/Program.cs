using System;
using System.Collections.Generic;

namespace Ex._01.UniqueUsernams
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            HashSet<string> uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < nLines; i++)
            {
                string username = Console.ReadLine();
                uniqueUsernames.Add(username);
            }

            foreach (string username in uniqueUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
