namespace _06.MinerTask
{
    using System;
    using System.Collections.Generic;
    class MinerTask
    {
        static void Main()
        {
            Dictionary<string, int> mine = new Dictionary<string, int>();
            string resource = String.Empty;

            while (true)
            {

                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int q = int.Parse(Console.ReadLine());
                if (!mine.ContainsKey(resource))
                {
                    mine.Add(resource, 0);
                }

                mine[resource] += q;
            }
            foreach (KeyValuePair<string, int> kv in mine)
            {
                Console.WriteLine(kv.Key+" -> "+ kv.Value);
            }
        }
    }
}
