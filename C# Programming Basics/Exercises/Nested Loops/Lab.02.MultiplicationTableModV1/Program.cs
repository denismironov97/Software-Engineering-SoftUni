using System;

namespace Lab._02.MultiplicationTableModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier1 = 1;
            int multiplier2 = 1;

            while (multiplier1 <= 10)
            {
                while (multiplier2 <= 10)
                {
                    Console.WriteLine($"{multiplier1} * {multiplier2} = {multiplier1 * multiplier2}");
                    multiplier2++;
                }

                multiplier2 = 1;
                multiplier1++;
            }
        }
    }
}
