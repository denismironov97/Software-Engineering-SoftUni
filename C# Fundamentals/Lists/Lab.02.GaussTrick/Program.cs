using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab._02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int lengh = numbersList.Count / 2;
            for (int i = 0; i < lengh; i++)
            {
                numbersList[i] += numbersList[numbersList.Count - 1];
                numbersList.RemoveAt(numbersList.Count - 1);
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
