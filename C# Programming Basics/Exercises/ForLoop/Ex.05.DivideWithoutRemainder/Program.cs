using System;

namespace Ex._05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // interval of 1 incl to 1000 incl
            int counterForCategoryP1 = 0;
            int counterForCatergoryP2 = 0;
            int counterForCatergoryP3 = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                
                if (inputNumber % 2 == 0) // p1
                {
                    counterForCategoryP1++;
                }
                if (inputNumber % 3 == 0) // p2 
                {
                    counterForCatergoryP2++;
                }
                if (inputNumber % 4 == 0) // p3 
                {
                    counterForCatergoryP3++;
                }
            }

            Console.WriteLine($"{counterForCategoryP1 / (n * 1.0) * 100:f2}%");
            Console.WriteLine($"{counterForCatergoryP2 / (n * 1.0) * 100:f2}%");
            Console.WriteLine($"{counterForCatergoryP3 / (n * 1.0) * 100:f2}%");
        }
    }
}
