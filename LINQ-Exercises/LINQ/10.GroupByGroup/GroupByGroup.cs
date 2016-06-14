namespace _10.GroupByGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class GroupByGroup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<string[]> lines = new List<string[]>();
            while (input != "END")
            {
                string[] studentInfo = input.Split();
                lines.Add(
                    new[]
                        {
                            studentInfo[0] + " " + studentInfo[1], studentInfo[2]
                        });
                input = Console.ReadLine();
            }

            var result = lines
                .GroupBy(p => p[1])
                .ToDictionary(g => int.Parse(g.Key), g => g.ToArray())
                .OrderBy(p => p.Key);


            foreach (var group in result)
            {
                List<string> names = group.Value.Select(v => v[0]).ToList();
                Console.WriteLine(group.Key + " - " + string.Join(", ", names));
            }
        }
    }
}
