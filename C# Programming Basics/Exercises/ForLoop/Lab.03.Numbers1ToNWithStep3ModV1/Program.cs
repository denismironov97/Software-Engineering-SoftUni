using System;

namespace Lab._03.Numbers1ToNWithStep3ModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i += 3)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
