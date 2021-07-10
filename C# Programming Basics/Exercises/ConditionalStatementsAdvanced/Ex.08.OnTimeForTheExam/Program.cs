using System;

namespace Ex._08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArival = int.Parse(Console.ReadLine());
            int examInMinutes = hourOfExam * 60 + minutesOfExam; // combined time in minutes
            int arrivalInMinutes = hourOfArrival * 60 + minutesOfArival; // combined time in minutes of arrival
            
            if (arrivalInMinutes > examInMinutes) // late
            {
                if ((arrivalInMinutes - examInMinutes) >= 1 && (arrivalInMinutes - examInMinutes) < 60) // за закъснение под 1 час. 
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{arrivalInMinutes - examInMinutes} minutes after the start");
                }
                else // за закъснение над 1 час
                {
                    if (((arrivalInMinutes - examInMinutes) % 60) < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{(arrivalInMinutes - examInMinutes) / 60}:0{(arrivalInMinutes - examInMinutes) % 60} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{(arrivalInMinutes - examInMinutes) / 60}:{(arrivalInMinutes - examInMinutes) % 60} hours after the start");
                    }
                }
            }
            else if (arrivalInMinutes == examInMinutes) // right on time   
            {
                Console.WriteLine("On time");
            }
            else if (examInMinutes > arrivalInMinutes) // early
            {
                if ((examInMinutes - arrivalInMinutes) <= 30) // 30 mins before exam <=
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{examInMinutes - arrivalInMinutes} minutes before the start");
                }
                else if ((examInMinutes - arrivalInMinutes) >= 1 && (examInMinutes - arrivalInMinutes) < 60) // подранил до 1 час до изпита 
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{examInMinutes - arrivalInMinutes} minutes before the start");
                }
                else // подранил над 1 час и вклч
                {
                    if (((examInMinutes - arrivalInMinutes) % 60) < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{(examInMinutes - arrivalInMinutes) / 60}:0{(examInMinutes - arrivalInMinutes) % 60} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{ (examInMinutes - arrivalInMinutes) / 60}:{(examInMinutes - arrivalInMinutes) % 60} hours before the start");
                    }
                }
            }
        }
    }
}
