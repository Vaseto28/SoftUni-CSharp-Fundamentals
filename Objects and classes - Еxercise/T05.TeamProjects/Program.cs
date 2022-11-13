using System;
using System.Linq;
using System.Collections.Generic;

namespace T05.TeamProjects
{
    class Teams
    {
        public Teams(string teamCreator, string teamName, List<string> members)
        {
            this.TeamCreator = teamCreator;
            this.TeamName = teamName;
            this.Members = members;
        }

        public string TeamCreator { get; set; }

        public string TeamName { get; set; }

        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Teams> teams = new List<Teams>();
            for (int i = 1; i <= countOfTeams; i++)
            {
                string information = Console.ReadLine();
                string[] arguments = information.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string user = arguments[0];
                string teamName = arguments[1];
                List<string> members = new List<string>();

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.TeamCreator == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }

                Teams newTeam = new Teams(user, teamName, members);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string memberName = arguments[0];
                string teamName = arguments[1];

                Teams searchedTeam = teams.FirstOrDefault(t => t.TeamName == teamName);

                if (!teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                bool isTheMemberValid = true;
                foreach (var team in teams)
                {
                    if (team.TeamCreator == memberName && team.TeamName == teamName)
                    {
                        Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                        isTheMemberValid = false;
                        break;
                    }
                }
                if (!isTheMemberValid)
                {
                    continue;
                }

                if (teams.Any(t => t.TeamCreator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                searchedTeam.Members.Add(memberName);
            }

            List<Teams> teamsWithMembers = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();
            List<Teams> teamsToDisband = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName).ToList();

            foreach (Teams validTeam in teamsWithMembers)
            {
                Console.WriteLine($"{validTeam.TeamName}");
                Console.WriteLine($"- {validTeam.TeamCreator}");

                foreach (string currMember in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currMember}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Teams invalidTeam in teamsToDisband)
            {
                Console.WriteLine($"{invalidTeam.TeamName}");
            }
        }
    }
}
