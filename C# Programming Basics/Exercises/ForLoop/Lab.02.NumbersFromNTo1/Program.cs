﻿using System;

namespace Lab._02.NumbersFromNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i -= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
