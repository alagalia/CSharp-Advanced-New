namespace _11.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class LogsAggregator
    {
        static void Main()
        {
            SortedDictionary<string, int> nameDuration = new SortedDictionary<string, int>();
            Dictionary<string, SortedSet<string>> nameIps = new Dictionary<string, SortedSet<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split();
                string ip = args[0];
                string name = args[1];
                int duration = int.Parse(args[2]);

                if (!nameIps.ContainsKey(name))
                {
                    nameIps.Add(name, new SortedSet<string>());
                    nameDuration.Add(name, 0);
                }

                nameIps[name].Add(ip);
                nameDuration[name] += duration;
            }

            foreach (var kv in nameDuration)
            {
                StringBuilder nameInfo = new StringBuilder();
                nameInfo.Append(kv.Key + ": " + kv.Value + " [");
                string ipsInfo = string.Join(", ", nameIps[kv.Key]);
                nameInfo.Append(ipsInfo).Append("]");
                Console.WriteLine(nameInfo);
            }
        }
    }
}
