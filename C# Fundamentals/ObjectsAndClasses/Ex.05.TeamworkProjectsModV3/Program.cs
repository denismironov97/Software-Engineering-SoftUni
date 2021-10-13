using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Ex._05.TeamworkProjectsModV3
{
    public class Team
    {
        public Team(string teamName, string userCreator)
        {
            this.TeamName = teamName;
            this.UserCreator = userCreator;
            this.Teammates = new List<string>();
        }

        public string TeamName { get; set; }

        public string UserCreator { get; set; }

        public List<string> Teammates { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{this.TeamName}");
            Console.WriteLine($"- {this.UserCreator}");
            this.Teammates.Sort();//!important sort
            foreach (var member in this.Teammates)
            {
                Console.WriteLine($"-- {member}");
            }
        }

        public void PrintInfoTeamOnly()
        {
            Console.WriteLine($"{this.TeamName}");
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(this.TeamName);
            builder.AppendLine($"- {this.UserCreator}");

            this.Teammates.Sort();

            foreach (string member in this.Teammates)
            {
                builder.AppendLine($"-- {member}");
            }

            return builder.ToString().TrimEnd();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int totalCountOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < totalCountOfTeams; i++)
            {
                string[] teamDataParts = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                string userCreator = teamDataParts[0];
                string teamName = teamDataParts[1];

                //if a user tries to create a Team with already existing name among the other teams
                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(x => x.UserCreator == userCreator))
                {
                    Console.WriteLine($"{userCreator} cannot create another team!");
                    continue;
                }

                teams.Add(new Team(teamName, userCreator));

                Console.WriteLine($"Team {teamName} has been created by {userCreator}!");
            }

            string commandData;
            while ((commandData = Console.ReadLine()) != "end of assignment")
            {
                string[] teamDataParts = commandData.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string userOrMember = teamDataParts[0];//Maybe teammate or user!
                string teamName = teamDataParts[1];//SoftUni Coders

                // Search for a team with the given name.
                var specificTeam = teams.FirstOrDefault(x => x.TeamName == teamName);

                if (specificTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                // Check if the provided user is already a member/creator in another team.
                if (teams.Any(x => x.Teammates.Contains(userOrMember)) || teams.Any(x => x.UserCreator == userOrMember))
                {
                    Console.WriteLine($"Member {userOrMember} cannot join team {teamName}!");
                    continue;
                }

                specificTeam.Teammates.Add(userOrMember);
            }

            List<Team> validTeams = teams.Where(x => x.Teammates.Count > 0).OrderByDescending(x => x.Teammates.Count).ThenBy(x => x.TeamName).ToList();

            //foreach (Team currTeam in validTeams)
            //{
            //    currTeam.PrintInfo();
            //}

            //Console.WriteLine("Teams to disband:");
            //List<Team> teamsToDisband = teams.Where(x => x.Teammates.Count == 0).OrderBy(x => x.TeamName).ToList();

            //foreach (Team currTeam in teamsToDisband)
            //{
            //    currTeam.PrintInfoTeamOnly();
            //}

            foreach (var team in validTeams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Teams to disband:");
            List<Team> teamsToDisband = teams.Where(x => x.Teammates.Count == 0).OrderBy(x => x.TeamName).ToList();
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
