using System;
using System.Linq;

namespace Lab._04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
            Func<double, double> addingVATFunc = x => 1.2 * x;
            double[] resultOutput = numbersInput.Select(addingVATFunc).ToArray();

            foreach (double number in resultOutput)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
