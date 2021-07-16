using System;

namespace Lab._03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int currentnumber = 0;
            int sum = 0;
            
            while (true)
            {
                currentnumber = int.Parse(Console.ReadLine());
                sum += currentnumber;
                
                if (sum >= numberInput)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
