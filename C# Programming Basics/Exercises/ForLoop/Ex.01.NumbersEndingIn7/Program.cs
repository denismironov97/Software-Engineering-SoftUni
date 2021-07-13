using System;

namespace Ex._01.NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 7; i <= 997; i += 10)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
