using System;

namespace Ex._01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfWagon = int.Parse(Console.ReadLine());
            int[] wagons = new int[lenghtOfWagon];
            int sum = 0;

            for (int i = 0; i < lenghtOfWagon; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }

            foreach (int item in wagons)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
