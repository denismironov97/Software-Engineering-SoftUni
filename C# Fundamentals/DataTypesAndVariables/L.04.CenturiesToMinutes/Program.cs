using System;

namespace L._04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            int days = (int)(years * 365.2422); //•	Assume that a year has 365.2422 days at average 
            long hours = days * 24L;
            long minutes = hours * 60L;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
