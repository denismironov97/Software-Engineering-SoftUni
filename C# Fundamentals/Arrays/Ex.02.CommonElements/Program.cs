using System;

namespace Ex._02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string texts1 = Console.ReadLine();
            string[] arr1 = texts1.Split(' ');
            string texts2 = Console.ReadLine();
            string[] arr2 = texts2.Split(' ');
            string commonWords = string.Empty;

            //Method 1
            for (int i = 0; i < arr1.Length; i++)//arr1[j]
            {
                for (int j = 0; j < arr2.Length; j++)//arr2[j]
                {
                    if (arr1[i] == arr2[j])
                    {
                        commonWords += $"{arr1[i]} ";
                    }
                }
            }

            //Method 2
            /*
            for (int i = 0; i < arr2.Length; i++)//arr2[i]
            {
                for (int j = 0; j < arr1.Length; j++)//arr1[j]
                {
                    if (arr2[i] == arr1[j])
                    {
                        commonWords = commonWords + arr2[i] + " ";
                    }
                }
            }
            */

            Console.WriteLine(commonWords);
        }
    }
}
