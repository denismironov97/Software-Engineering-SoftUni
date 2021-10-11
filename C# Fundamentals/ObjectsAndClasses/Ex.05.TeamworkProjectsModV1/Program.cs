using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Ex._05.TeamworkProjectsModV1
{
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

                Team currTeam = new Team(teamName, userCreator);

                //if a user tries to create a Team with already existing name among the other teams
                if (CheckForAlreadyExistingTeamName(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.All(x => x.UserCreator != userCreator))
                {
                    teams.Add(currTeam);
                }
                else
                {
                    Console.WriteLine($"{userCreator} cannot create another team!");//if user want's to create a different team
                    continue;
                }

                Console.WriteLine($"Team {teamName} has been created by {userCreator}!");
            }

            string commandData;
            while ((commandData = Console.ReadLine()) != "end of assignment")
            {
                string[] teamDataParts = commandData.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string userOrMember = teamDataParts[0];//Maybe teammate or user!
                string teamName = teamDataParts[1];//SoftUni Coders

                //Checks if there is a Team with such given name
                if (!CheckForAlreadyExistingTeamName(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                //Checks if user tries to join a different team or his own team and checks if a member(not a user) who is already part of a Team wants to join another Team
                if (teams.Any(x => x.UserCreator == userOrMember) || CheckIfTeammemberWantsToJoinAnotherTeam(teams, userOrMember))
                {
                    Console.WriteLine($"Member {userOrMember} cannot join team {teamName}!");
                    continue;
                }

                AddMemberToTeam(teams, userOrMember, teamName);
            }

            List<Team> validTeams = teams.Where(x => x.Teammates.Count > 0).OrderByDescending(x => x.Teammates.Count).ThenBy(x => x.TeamName).ToList();

            foreach (Team currTeam in validTeams)
            {
                Console.WriteLine(currTeam);
            }

            Console.WriteLine("Teams to disband:");
            List<Team> teamsToDisband = teams.Where(x => x.Teammates.Count == 0).OrderBy(x => x.TeamName).ToList();

            foreach (Team currTeam in teamsToDisband)
            {
                Console.WriteLine(currTeam.TeamName);
            }
        }

        //Checks if a different user tries to create a Team with already existing name among the other teams
        private static bool CheckForAlreadyExistingTeamName(List<Team> collection, string teamName)
        {
            foreach (var currTeam in collection)
            {
                if (currTeam.TeamName == teamName)
                {
                    return true;
                }
            }

            return false;
        }

        //Checks if a member(not a user) who is already part of a Team wants to join another Team
        private static bool CheckIfTeammemberWantsToJoinAnotherTeam(List<Team> collection, string member)
        {
            foreach (var currTeam in collection)
            {
                List<string> currTeamMembers = currTeam.Teammates;
                if (currTeamMembers.Contains(member))
                {
                    return true;
                }
            }

            return false;
        }

        private static void AddMemberToTeam(List<Team> teams, string member, string teamName)
        {
            foreach (Team currTeam in teams)
            {
                if (currTeam.TeamName == teamName)
                {
                    currTeam.Teammates.Add(member);
                    break;
                }
            }
        }
    }

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
}

