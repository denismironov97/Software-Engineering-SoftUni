using System;

namespace Ex._03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;// string = "";
            int primeSum = 0;
            int nonPrimeSum = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                int currentNum = int.Parse(input);
                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                int countForDivisions = 0;
                for (int numberOfDivisors = 1; numberOfDivisors <= currentNum; numberOfDivisors++)
                {
                    if (currentNum % numberOfDivisors == 0) // prime number 
                    {
                        countForDivisions++;
                    }
                }
                if (countForDivisions > 2) // nonPRimenumber 
                {
                    nonPrimeSum += currentNum;
                }
                else // prime number 
                {
                    primeSum += currentNum;
                }

            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
