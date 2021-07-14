using System;

namespace Ex._03.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // num of rows 
            int positionOfNum = 0; // to count the positions at the end of the cycle 
            double oddMinValue = double.MaxValue; //  100
            double oddMaxValue = double.MinValue; // -100
            double oddSum = 0;
            double evenMinValue = double.MaxValue;
            double evenMaxValue = double.MinValue;
            double evenSum = 0;
            
            if (n > 0)
            {
                for (positionOfNum = 1; positionOfNum <= n; positionOfNum++)
                {
                    double inputNumber = double.Parse(Console.ReadLine());
                    
                    if (positionOfNum % 2 != 0) // odd position
                    {
                        oddSum += inputNumber;
                        if (inputNumber < oddMinValue)
                        {
                            oddMinValue = inputNumber;
                        }
                        if (inputNumber > oddMaxValue)
                        {
                            oddMaxValue = inputNumber;
                        }
                    }
                    else // even position 
                    {
                        evenSum += inputNumber;
                        if (inputNumber < evenMinValue)
                        {
                            evenMinValue = inputNumber;
                        }
                        if (inputNumber > evenMaxValue)
                        {
                            evenMaxValue = inputNumber;
                        }
                    }
                }
               
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMinValue:f2},");
                Console.WriteLine($"OddMax={oddMaxValue:f2},");
                positionOfNum -= 1;  
                
                if (positionOfNum > 1)
                {
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin={evenMinValue:f2},");
                    Console.WriteLine($"EvenMax={evenMaxValue:f2}");
                }
                else
                {
                    Console.WriteLine($"EvenSum={evenSum:f2},");
                    Console.WriteLine($"EvenMin=No,");
                    Console.WriteLine($"EvenMax=No");
                }
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
