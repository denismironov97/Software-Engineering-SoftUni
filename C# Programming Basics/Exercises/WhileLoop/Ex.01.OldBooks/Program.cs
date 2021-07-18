using System;

namespace Ex._01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int counter = 0;
            bool isFound = false;
            
            while (currentBook != "No More Books")
            {
                if (currentBook == favBook)
                {
                    isFound = true;
                    break;
                }

                counter = counter + 1;
                currentBook = Console.ReadLine();
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
