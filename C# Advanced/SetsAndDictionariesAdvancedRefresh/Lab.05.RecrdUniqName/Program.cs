using System;
using System.Collections.Generic;

namespace Lab._05.RecrdUniqName
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < nLines; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, uniqueNames));
        }
    }
}
