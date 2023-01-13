using System;

namespace Ex._01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> printAction = x => Console.WriteLine(x);

            foreach (string item in inputData)
            {
                printAction(item);
            }
        }
    }
}
