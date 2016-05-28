namespace _08.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<int, HashSet<int>>> handsInfo = new Dictionary<string, Dictionary<int, HashSet<int>>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "JOKER")
                {
                    break;
                }

                string name = line.Split(':')[0];
                string[] cards = line
                    .Split(':')[1]
                    .Replace("10", "1")
                    .Split(
                    new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (!handsInfo.ContainsKey(name))
                {
                    handsInfo.Add(name, new Dictionary<int, HashSet<int>>());
                }

                foreach (string c in cards)
                {
                    string card = c.Trim();
                    string faceAsString = card[0].ToString();
                    string suitAsString = card[1].ToString();
                    int suit = GetSuit(suitAsString);
                    int face = GetFace(faceAsString);
                    if (!handsInfo[name].ContainsKey(suit))
                    {
                        handsInfo[name].Add(suit, new HashSet<int>());
                    }

                    handsInfo[name][suit].Add(face);
                }
            }

            foreach (var outerPair in handsInfo)
            {
                string line = outerPair.Key + ": ";

                int value = outerPair.Value.Sum(innerPair => innerPair.Key * innerPair.Value.Sum());
                Console.WriteLine(line + value);
            }
        }

        private static int GetFace(string face)
        {
            switch (face)
            {
                case "1":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(face);
            }
        }

        private static int GetSuit(string suit)
        {
            switch (suit)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
