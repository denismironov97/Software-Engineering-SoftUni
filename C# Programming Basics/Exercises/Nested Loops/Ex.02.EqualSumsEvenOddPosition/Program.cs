using System;

namespace Ex._02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine()); // min=100 000 max=300 000;
            int secondNum = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = firstNum; i <= secondNum; i++) // изреждаме, преминаваме през всички числа в границата от двете числа;
            {
                string currentNum = i.ToString(); // моментното число го превръщаме в стринг 
                for (int j = 0; j < currentNum.Length; j++) // обхождаме  всяка цифра на самото число
                {
                    int currentDigit = int.Parse(currentNum[j].ToString()); //цифрата от текст превръщаме в количествен израз
                    if (j % 2 == 0) //
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
                evenSum = 0;
                oddSum = 0;
            }

            //int number1 = int.Parse(Console.ReadLine()); // min=100 000 max=300 000;
            //int number2 = int.Parse(Console.ReadLine());
            //for (int i = number1; i <= number2; i++)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
