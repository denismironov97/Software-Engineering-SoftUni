using System;

namespace Lab._06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputnum = Console.ReadLine();
            int maxValue = int.MinValue;
            
            while (inputnum != "Stop")
            {
                int currentNum = int.Parse(inputnum);
                
                if (currentNum > maxValue)
                {
                    maxValue = currentNum;
                }
                inputnum = Console.ReadLine();
            }

            Console.WriteLine(maxValue);
        }
    }
}
