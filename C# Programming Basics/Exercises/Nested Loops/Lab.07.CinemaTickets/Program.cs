using System;

namespace Lab._07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieTitle = Console.ReadLine();
            int totalTickets = 0;
            int countForStudentTicketsTotal = 0;
            int countForStandardTicketsTotal = 0;
            int countForKidsTicketsTotal = 0;

            while (movieTitle != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                string typeOfTicket = Console.ReadLine();
                int currentlyTackenSeats = 0;

                while (typeOfTicket != "End")
                {
                    if (typeOfTicket == "student")
                    {
                        currentlyTackenSeats++;
                        countForStudentTicketsTotal++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        currentlyTackenSeats++;
                        countForStandardTicketsTotal++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        currentlyTackenSeats++;
                        countForKidsTicketsTotal++;
                    }

                    if (currentlyTackenSeats == availableSeats)
                    {
                        break;
                    }

                    typeOfTicket = Console.ReadLine();
                }

                totalTickets = totalTickets + currentlyTackenSeats;
                Console.WriteLine($"{movieTitle} - {currentlyTackenSeats * 1.0 / availableSeats * 100:f2}% full.");
                movieTitle = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{countForStudentTicketsTotal * 1.0 / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{countForStandardTicketsTotal * 1.0 / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{countForKidsTicketsTotal * 1.0 / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
