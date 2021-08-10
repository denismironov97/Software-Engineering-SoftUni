using System;

namespace Ex._08.TriangleNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numOfRows; i++) // cyckle for the rows 
            {
                for (int j = 1; j <= i; j++) // cyckle for the colllons 
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
    }
}
