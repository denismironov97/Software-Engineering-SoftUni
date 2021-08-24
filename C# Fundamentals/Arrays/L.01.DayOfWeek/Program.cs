using System;

namespace L._01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfTheWeek = int.Parse(Console.ReadLine());
            //string[] week = new string[7] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" , "Sunday" };
            //string[] week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (dayOfTheWeek > 0 && dayOfTheWeek <= 7) // 
            {
                Console.WriteLine(week[dayOfTheWeek - 1]); // arrays are zero based index
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
