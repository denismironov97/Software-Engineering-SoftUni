using System;

namespace Ex._05.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++) //symbol1
            {
                for (int j = 1; j < n; j++) //symbol2 
                {
                    for (int k = 97; k < 97 + l; k++) //symbol3 cw((char)k) 
                    {
                        for (int m = 97; m < 97 + l; m++) //symbol4 cw((char)m)
                        {
                            for (int q = 1; q <= n; q++) //symbol5 
                            {
                                if (q > i && q > j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)m}{q} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
