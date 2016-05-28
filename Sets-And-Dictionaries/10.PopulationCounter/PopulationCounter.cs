namespace _10.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> info = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> totalPopulation = new Dictionary<string, long>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "report")
                {
                    PrintResult(info, totalPopulation);
                    break;
                }

                string[] args = line.Split('|');
                string city = args[0];
                string country = args[1];
                long population = long.Parse(args[2]);
                if (!info.ContainsKey(country))
                {
                    info.Add(country, new Dictionary<string, long>());
                    info[country].Add(city, 0);

                    totalPopulation.Add(country, 0);
                }

                if (!info[country].ContainsKey(city))
                {
                    info[country].Add(city, 0);
                }

                info[country][city] += population;
                totalPopulation[country] += population;
            }
        }

        private static void PrintResult(
            Dictionary<string, Dictionary<string, long>> info,
            Dictionary<string, long> totalPopulation)
        {
            var sortedCountriesByTotalPopulation = 
                from entry in totalPopulation 
                orderby entry.Value descending 
                select entry;

            foreach (var country in sortedCountriesByTotalPopulation)
            {
                var sortedCitiesByTotalPopulation =
                    from entry in info[country.Key] 
                    orderby entry.Value descending 
                    select entry;

                Console.WriteLine(country.Key + " (total population: " + country.Value + ")");

                foreach (var city in sortedCitiesByTotalPopulation)
                {
                    Console.WriteLine("=>" + city.Key + ": " + city.Value);
                }
            }
        }
    }
}
