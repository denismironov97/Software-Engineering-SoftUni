using System;
using System.Collections.Generic;

namespace Ex._03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLinesOfInput = int.Parse(Console.ReadLine());
            SortedSet<string> uniqueChemCompounds = new SortedSet<string>();

            for (int i = 0; i < nLinesOfInput; i++)
            {
                string[] chemicalCompoundInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < chemicalCompoundInput.Length; j++)
                {
                    uniqueChemCompounds.Add(chemicalCompoundInput[j]);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueChemCompounds));
        }
    }
}
