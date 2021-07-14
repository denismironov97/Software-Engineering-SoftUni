using System;

namespace Ex._06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOpenedBrowsers = int.Parse(Console.ReadLine()); // interval 1 to 10
            int salary = int.Parse(Console.ReadLine()); // interval from 700 incl to 1500 incl
            
            for (int openBrowsers = 1; openBrowsers <= numberOfOpenedBrowsers; openBrowsers++)
            {
                string currentOpenedBrowser = Console.ReadLine();
                
                if (currentOpenedBrowser == "Facebook")
                {
                    salary -= 150;
                }
                else if (currentOpenedBrowser == "Instagram")
                {
                    salary -= 100;
                }
                else if (currentOpenedBrowser == "Reddit")
                {
                    salary -= 50;
                }
               
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break; // learn how to use "break"; understand "break;"
                }
            }
            
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
