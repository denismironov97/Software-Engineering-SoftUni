using System;

namespace Ex._04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfPagesInWholeBook = double.Parse(Console.ReadLine());
            double numOfPagesOnehour = double.Parse(Console.ReadLine());
            int numOfDaysToReadBook = int.Parse(Console.ReadLine());
            double totalTime = numOfPagesInWholeBook / numOfPagesOnehour;
            double hoursPerDay = totalTime / numOfDaysToReadBook;
            Console.WriteLine(Math.Floor(hoursPerDay));
        }
    }
}
