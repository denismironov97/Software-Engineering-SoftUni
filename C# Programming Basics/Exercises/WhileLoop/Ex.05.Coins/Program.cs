using System;

namespace Ex._05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2.00; 1.00; 0.50; 0.20; 0.10; 0.05; 0.02; 0.01;

            double inputChange = double.Parse(Console.ReadLine());
            int coinCounter = 0;

            while (!((Math.Round(inputChange, 2)) == 0))
            {
                if (Math.Round(inputChange, 2) >= 2.00)
                {

                    inputChange = Math.Round(inputChange, 2) - 2;
                    coinCounter++;
                    continue;
                }

                if (Math.Round(inputChange, 2) >= 1.00)
                {
                    inputChange = Math.Round(inputChange, 2) - 1;
                    coinCounter++;
                    continue;
                }

                if (Math.Round(inputChange, 2) >= 0.50)
                {
                    inputChange = Math.Round(inputChange, 2) - 0.50;
                    coinCounter++;
                    continue;
                }

                if (Math.Round(inputChange, 2) >= 0.20)
                {
                    inputChange = Math.Round(inputChange, 2) - 0.20;
                    coinCounter++;
                    continue;
                }

                if (Math.Round(inputChange, 2) >= 0.10)
                {
                    inputChange = Math.Round(inputChange, 2) - 0.10;
                    coinCounter++;
                    continue;
                }

                if (Math.Round(inputChange, 2) >= 0.05)
                {
                    inputChange = Math.Round(inputChange, 2) - 0.05;
                    coinCounter++;
                    continue;
                }

                if (Math.Round(inputChange, 2) >= 0.02)
                {
                    inputChange = Math.Round(inputChange, 2) - 0.02;
                    coinCounter++;
                    continue;
                }

                if (Math.Round(inputChange, 2) >= 0.01)
                {
                    inputChange = Math.Round(inputChange, 2) - 0.01;
                    coinCounter++;
                    continue;
                }
            }

            Console.WriteLine(coinCounter);
        }
    }
}
