﻿using System;

namespace L._07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimiter = Console.ReadLine();
            //Console.WriteLine($"{name1}{delimiter}{name2}");
            Console.WriteLine("{0}{1}{2}", name1, delimiter, name2);
        }
    }
}
