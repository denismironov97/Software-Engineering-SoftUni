using System;

namespace Ex._04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // interval from 1 included to 1000 included 
            // n = num of rows of which contains one num in each row, therefore n is also = total numbers or can be a counter for numbers;
            int counterForCategoryP1 = 0;
            int counterForCategoryP2 = 0;
            int counterForCategoryP3 = 0;
            int counterForCategoryP4 = 0;
            int counterForCategoryP5 = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                
                if (inputNumber < 200) // p1 
                {
                    counterForCategoryP1 += 1;
                }
                else if (inputNumber >= 200 && inputNumber < 400) //p2
                {
                    counterForCategoryP2 += 1;
                }
                else if (inputNumber >= 400 && inputNumber < 600) //p3
                {
                    counterForCategoryP3++;
                }
                else if (inputNumber >= 600 && inputNumber < 800) //p4 
                {
                    counterForCategoryP4++;
                }
                else // for 800 and above // p5 
                {
                    counterForCategoryP5++;
                }
            }
            
            Console.WriteLine($"{(counterForCategoryP1 * 1.0 / n * 100):f2}%");
            Console.WriteLine($"{(counterForCategoryP2 * 1.0 / n * 100):f2}%");
            Console.WriteLine($"{(counterForCategoryP3 * 1.0 / n * 100):f2}%");
            Console.WriteLine($"{(counterForCategoryP4 * 1.0 / n * 100):f2}%");
            Console.WriteLine($"{(counterForCategoryP5 * 1.0 / n * 100):f2}%");
        }
    }
}
