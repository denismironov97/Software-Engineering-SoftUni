using System;

namespace Ex._04.PrintAndsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int stratingNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;
            while (stratingNum <= endNum)
            {
                Console.Write(stratingNum + " ");
                sum += stratingNum;
                stratingNum++;
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
