using System;

namespace Lab._03.Numbers1ToNWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(int a = 1; a <= number; a += 3)
            {
                Console.WriteLine(a);
            }
        }
    }
}
