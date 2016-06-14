using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.OfficeStuff
{
   class OfficeStuff
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, List<Stuff>> catalog = new SortedDictionary<string, List<Stuff>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string company = input[0].Substring(1, input[0].Length - 1);
                string productName = input[4].Substring(0, input[4].Length - 1);
                int amount = int.Parse(input[2]);

                Stuff currentStuff = new Stuff(productName);
                currentStuff.Amount += amount;
                if (!catalog.ContainsKey(company))
                {
                    catalog[company] = new List<Stuff>(); 
                }

                if (catalog[company].Any(el => el.Name == productName))
                {
                    Stuff firstOrDefault = catalog[company].FirstOrDefault(el => el.Name == productName);
                    if (firstOrDefault != null)
                    {
                        firstOrDefault.Amount += amount;
                    }
                }
                else
                {
                    catalog[company].Add(currentStuff);
                }
            }

            foreach (var elem in catalog)
            {
                Console.WriteLine(elem.Key + ": " + string.Join(", ", elem.Value.Select(el => el.ToString()).ToList()));
            }
        }
    }

    public class Stuff
    {
        public Stuff(string name)
        {
            this.Name = name;
            this.Amount = 0;
        }

        public string Name { get; set; }

        public int Amount { get; set; }

        public override string ToString()
        {
            return this.Name + "-" + this.Amount;
        }
    }
}
