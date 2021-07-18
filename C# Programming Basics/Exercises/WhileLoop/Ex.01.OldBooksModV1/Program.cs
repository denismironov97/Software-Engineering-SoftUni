using System;

namespace Ex._01.OldBooksModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            string currentBook = "";
            int counterForBooks = 0;
            
            while ((currentBook = Console.ReadLine()) != favouriteBook && currentBook != "No More Books")
            {
                counterForBooks++;
            }

            if (currentBook == favouriteBook)
            {
                Console.WriteLine($"You checked {counterForBooks} books and found it.");
            }
            else if (currentBook == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counterForBooks} books.");
            }
        }
    }
}
