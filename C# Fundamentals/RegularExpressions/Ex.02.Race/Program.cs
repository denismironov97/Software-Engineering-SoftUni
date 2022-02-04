using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex._02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesOfRunners = Console.ReadLine().Split(", ");
            Dictionary<string, int> runnersNameAndDistanceRan = new Dictionary<string, int>();

            for (int i = 0; i < namesOfRunners.Length; i++)
            {
                runnersNameAndDistanceRan.Add(namesOfRunners[i], 0);
            }

            string inputData = string.Empty;
            //Regex regex = new Regex(@"([A-Za-z])|(\d)|([!@#$%^&*])");
            Regex regex = new Regex(@"([A-Za-z])|(\d)");

            //Group 1 = Letters
            //Group 2 = Numbers
            //Group 3 = Symbols

            while ((inputData = Console.ReadLine()) != "end of race")
            {
                MatchCollection runnerInformation = regex.Matches(inputData);

                string nameOfRunner = "";
                int ranDistanseOfRunner = 0;

                foreach (Match letterOrDigit in runnerInformation)
                {
                    char letterOrDigitFromMatch = char.Parse(letterOrDigit.ToString());

                    if (char.IsDigit(letterOrDigitFromMatch))
                    {
                        ranDistanseOfRunner += letterOrDigitFromMatch - 48;
                    }
                    else if (char.IsLetter(letterOrDigitFromMatch))
                    {
                        nameOfRunner += letterOrDigitFromMatch;
                    }
                }

                if (runnersNameAndDistanceRan.ContainsKey(nameOfRunner))
                {
                    runnersNameAndDistanceRan[nameOfRunner] += ranDistanseOfRunner;
                }
            }

            Dictionary<string, int> sortedRunnersByRanDistance = runnersNameAndDistanceRan
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            int placeInRace = 0;

            foreach (var kvp in sortedRunnersByRanDistance)
            {
                placeInRace++;
                switch (placeInRace)
                {
                    case 1:
                        Console.WriteLine($"{placeInRace}st place: {kvp.Key}");
                        break;
                    case 2:
                        Console.WriteLine($"{placeInRace}nd place: {kvp.Key}");
                        break;
                    case 3:
                        Console.WriteLine($"{placeInRace}rd place: {kvp.Key}");
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
