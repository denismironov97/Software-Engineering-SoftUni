using System;

namespace Lab._02.WkndWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheWeek = Console.ReadLine();
            string result;

            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    result = "Working day";
                    break;
                case "Saturday":
                case "Sunday":
                    result = "Weekend";
                    break;
                default:
                    result = "Error";
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
