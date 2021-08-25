using System;

namespace L._04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] arrString = values.Split();//
            int arrStringLenght = arrString.Length;
            for (int i = 0; i < arrStringLenght / 2; i++)
            {
                string oldElement = arrString[i];
                arrString[i] = arrString[arrString.Length - 1 - i];
                arrString[arrString.Length - 1 - i] = oldElement;
            }
            Console.WriteLine(string.Join(" ", arrString));
        }
    }
}
