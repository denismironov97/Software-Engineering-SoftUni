using System;
using System.Linq;

namespace Ex._02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string[], string[]> addingKnightTitleFunc = x => x.Select(item => "Sir " + item).ToArray();

            Action<string[]> printAction = x =>
            {
                foreach (string name in x)
                {
                    Console.WriteLine(name);
                }
            };

            printAction(addingKnightTitleFunc(names));
        }
    }
}
