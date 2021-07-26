using System;

namespace Lab._07.PrjCre_ion
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int numberOfProjcets = int.Parse(Console.ReadLine());
            int hoursToCompleteProjects = numberOfProjcets * 3;
            //Console.WriteLine($"The architect {nameOfArchitect} will need {hoursToCompleteProjects} hours to complete {numberOfProjcets} project/s.");
            Console.WriteLine($"The architect {nameOfArchitect} will need {numberOfProjcets * 3} hours to complete {numberOfProjcets} project/s.");
        }
    }
}
