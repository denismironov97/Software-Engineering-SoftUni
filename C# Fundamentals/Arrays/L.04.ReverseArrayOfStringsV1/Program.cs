using System;

namespace L._04.ReverseArrayOfStringsV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayString = Console.ReadLine().Split();
            int arrLenght = arrayString.Length;
            for (int i = arrLenght - 1; i >= 0; i--)
            {
                Console.Write($"{ arrayString[i]} ");
            }
        }
    }
}
