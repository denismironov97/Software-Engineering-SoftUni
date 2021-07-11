using System;

namespace Lab._06.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            int sum = 0;
            
            for (int n = 0; n < length; n++)
            {
                if (input[n] == 'a')
                {
                    sum += 1;//sum++
                }
                if (input[n] == 'e')
                {
                    sum = sum + 2;
                }
                if (input[n] == 'i')
                {
                    sum += 3;
                }
                if (input[n] == 'o')
                {
                    sum += 4;
                }
                if (input[n] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
