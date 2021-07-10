using System;

namespace Ex._09.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int numOfHolidaysInSingleYear = int.Parse(Console.ReadLine()); // p
            int numOfWeekendsTravelsHome = int.Parse(Console.ReadLine()); // h // number of weekends he travels home 
            int weekendsInWholeYear = 48;
            double weekendsInSofia = weekendsInWholeYear - numOfWeekendsTravelsHome;
            double weekendsPlaysBallInSofia = (weekendsInSofia * 1.0) * 3 / 4; // Saturdays he plays ball = Times he played ball
            double playsVoleyBallOnHollidays = (numOfHolidaysInSingleYear * 1.0) * 2 / 3; // Times he played ball
            double weekendsPlaysBallInHomeTown = numOfWeekendsTravelsHome; // Sundays he played ball = Times he played ball;
            double totalTimesPlayedBall = 0;
            
            if (!(typeOfYear == "leap")) // normal year 
            {
                totalTimesPlayedBall = weekendsPlaysBallInSofia + playsVoleyBallOnHollidays + weekendsPlaysBallInHomeTown;
            }
            else // leap year plays + 15% more 
            {
                totalTimesPlayedBall = (weekendsPlaysBallInSofia + playsVoleyBallOnHollidays + weekendsPlaysBallInHomeTown) * 1.15;
            }
            Console.WriteLine(Math.Floor(totalTimesPlayedBall));
        }
    }
}
