﻿using System;

namespace Lab._02.NumbersFromNTo1ModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
