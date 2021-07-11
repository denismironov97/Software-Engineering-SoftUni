using System;

namespace Lab._04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int a = 2;

            for (int i = 0; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(a, i));
                }

            }


            //for (int i = 0; i <= b; i += 2)
            //{
            //    Console.WriteLine(Math.Pow(a, i));
            //}
        }
    }
}
