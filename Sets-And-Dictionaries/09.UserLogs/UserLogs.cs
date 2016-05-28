namespace _09.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> info = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] lineArgs = line.Split();
                string address = lineArgs[0].Split('=')[1];
                string user = lineArgs[2].Split('=')[1];
                if (!info.ContainsKey(user))
                {
                    info.Add(user, new Dictionary<string, int>());
                    info[user].Add(address, 0);
                }

                if (!info[user].ContainsKey(address))
                {
                    info[user].Add(address, 0);
                }

                info[user][address]++;
            }

            foreach (var outerPair in info)
            {
                Console.WriteLine(outerPair.Key + ":");
                string userInfo = string.Join(", ", outerPair.Value.Select(kv => kv.Key + " => " + kv.Value)) + ".";
                Console.WriteLine(userInfo);
            }
        }
    }
}
