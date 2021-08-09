using System;

namespace Ex._06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine(); //145
            int lenghtOfNum = inputNum.Length;
            int sumOfFacktoriels = 0;
            for (int digitCount = 0; digitCount < lenghtOfNum; digitCount++)
            {
                int currentFacktoriel = inputNum[digitCount] - 48;//important has to to with ASCII table
                //Console.WriteLine(currentFacktoriel);
                int currentProduct = 1;
                for (int a = 1; a <= currentFacktoriel; a++)//
                {
                    currentProduct *= a;
                }
                sumOfFacktoriels += currentProduct;
            }
            int parsedInputNum = int.Parse(inputNum);
            if (sumOfFacktoriels == parsedInputNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
