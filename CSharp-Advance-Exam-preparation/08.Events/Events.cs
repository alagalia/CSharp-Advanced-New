using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Events
{
    using System.Text.RegularExpressions;

    class Events
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, Dictionary<string, List<string>>> dataBase = new SortedDictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string line = Regex.Replace(Console.ReadLine(), @"\s+", " ");
                
                string pattern = @"^#(\w+):\s*@(\w+?)\s*([0-9]{1,2}:[0-9]{1,2})\b";
                Regex regHour = new Regex(pattern);
                string name = regHour.Match(line).Groups[1].Value;
                string location = regHour.Match(line).Groups[2].Value;
                string hour = regHour.Match(line).Groups[3].Value;

                if (!dataBase.ContainsKey(location))
                {
                    dataBase.Add(location, new Dictionary<string, List<string>>());
                }

                if (!dataBase[location].ContainsKey(name))
                {
                    dataBase[location].Add(name, new List<string>());
                }

                dataBase[location][name].Add(hour);
            }
            string filter = Console.ReadLine();

            var sortedData = dataBase.Where(d => !string.IsNullOrEmpty(d.Key)).OrderBy(d => d.Key);
            foreach (var outer in sortedData)
            {
                int counter = 1;
                if (filter.Contains(outer.Key))
                {
                    Console.WriteLine(outer.Key +":");
                    var sortedNames = outer.Value.OrderBy(st => st.Key);
                    foreach (var inner in sortedNames)
                    {
                        List<string> sortedHours = inner.Value.Where( hour => IsLegal(hour)).OrderBy(st => st).ToList();
                        Console.WriteLine(counter++ + ". " + inner.Key + " -> " + string.Join(", ", sortedHours));
                    }
                }
            }
        }

        private static bool IsLegal(string hour)
        {
            int a = int.Parse(hour.Split(':')[0]);
            int b = int.Parse(hour.Split(':')[1]);
            bool aIsLegal = a >= 0 && a <= 23;
            bool bIsLegal = b >= 0 && a <= 59;
            return aIsLegal && bIsLegal;
        }
    }   
}
