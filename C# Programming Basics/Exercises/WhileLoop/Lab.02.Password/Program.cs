using System;

namespace Lab._02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string usrename = Console.ReadLine();
            string password = Console.ReadLine();
            string passForEntrance = Console.ReadLine();
            
            while (password != passForEntrance)
            {
                passForEntrance = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {usrename}!");
        }
    }
}
