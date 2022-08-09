using System;
using System.Linq;

namespace Lab._01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNumbers = Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .Where(x => x % 2 == 0)
               .OrderBy(x => x)
               .ToArray();

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
