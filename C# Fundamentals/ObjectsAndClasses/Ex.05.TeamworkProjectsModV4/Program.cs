using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Ex._05.TeamworkProjectsModV4
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCountOfTeams = int.Parse(Console.ReadLine());
            Dictionary<string, Team> userCreatorTeamNameCollection = new Dictionary<string, Team>();//key->user, value->Team-Obj
            for (int i = 0; i < totalCountOfTeams; i++)
            {
                string[] teamDataParts = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                string userCreator = teamDataParts[0];
                string teamName = teamDataParts[1];

                Team currTeam = new Team(teamName, userCreator);

                //if a user tries to create a Team with already existing name among the other teams
                if (CheckForAlreadyExistingTeamName(userCreatorTeamNameCollection, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (!userCreatorTeamNameCollection.ContainsKey(userCreator))
                {
                    userCreatorTeamNameCollection.Add(userCreator, currTeam);
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
                if (!CheckForAlreadyExistingTeamName(userCreatorTeamNameCollection, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                //Checks if user tries to join a different team or his own team and checks if a member(not a user) who is already part of a Team wants to join another Team
                if (userCreatorTeamNameCollection.ContainsKey(userOrMember)
                    || CheckIfTeammemberWantsToJoinAnotherTeam(userCreatorTeamNameCollection, userOrMember))
                {
                    Console.WriteLine($"Member {userOrMember} cannot join team {teamName}!");
                    continue;
                }

                AddMemberToTeam(userCreatorTeamNameCollection, userOrMember, teamName);
            }


            Dictionary<string, Team> teamsToDisband = userCreatorTeamNameCollection.Where(x => x.Value.Teammates.Count == 0)
                                                                                   .OrderBy(x => x.Value.TeamName)
                                                                                   .ToDictionary(key => key.Key, value => value.Value);

            Dictionary<string, Team> validTeams = userCreatorTeamNameCollection.Where(x => x.Value.Teammates.Count > 0)
                                                                               .OrderByDescending(x => x.Value.Teammates.Count)
                                                                               .ThenBy(x => x.Value.TeamName)
                                                                               .ToDictionary(key => key.Key, value => value.Value);

            foreach (KeyValuePair<string, Team> kvp in validTeams)
            {
                Console.WriteLine(kvp.Value.TeamName);
                Console.WriteLine($"- {kvp.Key}");
                Console.WriteLine(kvp.Value);
            }

            Console.WriteLine("Teams to disband:");
            foreach (KeyValuePair<string, Team> kvp in teamsToDisband)
            {
                Console.WriteLine(kvp.Value.TeamName);
            }
        }

        //Checks if a different user tries to create a Team with already existing name among the other teams
        private static bool CheckForAlreadyExistingTeamName(Dictionary<string, Team> collection, string teamName)
        {
            foreach (var kvp in collection)
            {
                string currTeamName = kvp.Value.TeamName;
                if (currTeamName == teamName)
                {
                    return true;
                }
            }

            return false;
        }

        //Checks if a member(not a user) who is already part of a Team wants to join another Team
        private static bool CheckIfTeammemberWantsToJoinAnotherTeam(Dictionary<string, Team> collection, string member)
        {
            foreach (var kvp in collection)
            {
                List<string> currTeamMembers = kvp.Value.Teammates;
                if (currTeamMembers.Contains(member))
                {
                    return true;
                }
            }

            return false;
        }

        private static void AddMemberToTeam(Dictionary<string, Team> usersTeams, string member, string teamName)
        {
            foreach (KeyValuePair<string, Team> kvp in usersTeams)
            {
                string userCreator = kvp.Key;
                string currTeamName = kvp.Value.TeamName;

                if (currTeamName == teamName)
                {
                    usersTeams[userCreator].Teammates.Add(member);
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

            this.Teammates.Sort();

            foreach (string member in this.Teammates)
            {
                builder.AppendLine($"-- {member}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
