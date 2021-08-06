using System;

namespace L._10.Multipl_nTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = 1;
            for (int i = 1; i <= 10; i++)
            {
                var result = number * multiplier;
                Console.WriteLine("{0} X {1} = {2}", number, multiplier, result);
                multiplier++;
            }
        }
    }
}
