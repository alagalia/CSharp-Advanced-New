using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChampionsLeague
{
    public class Team
    {
       public string name { get; set; }
        public int wins;

    }
    class ChampionsLeague
    {
        static void Main()
        {
            Dictionary<string, SortedSet<string>> teamsOpponent = new Dictionary<string, SortedSet<string>>();
            Dictionary<string, int> teamsWins = new Dictionary<string, int>();

            string inputRaw = Console.ReadLine();
            while (inputRaw != "stop")
            {
                string[] input = inputRaw.Split('|').ToArray();
                string team1 = input[0].Trim();
                string team2 = input[1].Trim();
                int[] firstResult = input[2].Split(':').Select(int.Parse).ToArray();
                int[] secondResult = input[3].Split(':').Select(int.Parse).ToArray();

                if (!teamsOpponent.ContainsKey(team1))
                {
                    teamsOpponent.Add(team1, new SortedSet<string>());
                }

                if (!teamsOpponent.ContainsKey(team2))
                {
                    teamsOpponent.Add(team2, new SortedSet<string>());
                }

                if (!teamsWins.ContainsKey(team1))
                {
                    teamsWins.Add(team1, 0);
                }

                if (!teamsWins.ContainsKey(team2))
                {
                    teamsWins.Add(team2, 0);
                }

                teamsOpponent[team1].Add(team2);
                teamsOpponent[team2].Add(team1);

                string winner = ReturnWinner(firstResult[0], secondResult[1], firstResult[1], secondResult[0]);
                if (winner == "team1")
                {
                    teamsWins[team1]++;
                }
                else
                {
                    teamsWins[team2]++;
                }

                inputRaw = Console.ReadLine();
            }

            var sorted = teamsWins.OrderByDescending(kv => kv.Value).ThenBy(kv => kv.Key);
            foreach (var team in sorted)
            {
                Console.WriteLine(team.Key);
                Console.WriteLine("- Wins: " + team.Value);
                Console.WriteLine("- Opponents: " + string.Join(", ", teamsOpponent[team.Key]));
            }
        }

        private static string ReturnWinner(int firstResult0, int secondResult1, int firstResult1, int secondResult0)
        {
            int firstTeamScore = firstResult0 + secondResult1;
            int secondTeamScore = firstResult1 + secondResult0;
            if (firstTeamScore == secondTeamScore)
            {
                if (firstResult1 > secondResult1)
                {
                    return "team2";
                }
                return "team1";
            }

            return firstTeamScore < secondTeamScore ? "team2" : "team1";
        }
    }
}
