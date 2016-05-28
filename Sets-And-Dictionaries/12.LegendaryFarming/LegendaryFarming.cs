namespace _12.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            string[] goodMaterial = { "shards", "fragments", "motes" };
            Dictionary<string, int> allGoodMaterials = new Dictionary<string, int>() 
            {
                {
                    "shards", 0
                },
                {
                    "fragments", 0
                },
                {
                    "motes", 0
                }
            };
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            bool gameDone = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length - 1; i++)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[++i].ToLower();
                    if (goodMaterial.Contains(material))
                    {
                        allGoodMaterials[material] += quantity;

                        if (allGoodMaterials[material] >= 250)
                        {
                            PrintResult(material, allGoodMaterials, junk);
                            gameDone = true;
                            break;
                        }

                        continue;
                    }

                    if (!junk.ContainsKey(material))
                    {
                        junk.Add(material, 0);
                    }

                    junk[material] += quantity;
                }

                if (gameDone)
                {
                    break;
                }
            }
        }

        private static void PrintResult(
            string winnerMaterial,
            Dictionary<string, int> allGoodMaterials,
            SortedDictionary<string, int> junk)
        {
            string winner = string.Empty;
            switch (winnerMaterial)
            {
                case "shards":
                    winner = "Shadowmourne";
                    break;
                case "fragments":
                    winner = "Valanyr";
                    break;
                case "motes":
                    winner = "Dragonwrath";
                    break;
            }

            Console.WriteLine(winner + " obtained!");
            allGoodMaterials[winnerMaterial] -= 250;

            var sortedGoodMaterialsByQuantity = allGoodMaterials
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key);


            foreach (var kv in sortedGoodMaterialsByQuantity)
            {
                Console.WriteLine(kv.Key + ": " + kv.Value);
            }

            foreach (var kv in junk)
            {
                Console.WriteLine(kv.Key + ": " + kv.Value);
            }
        }
    }
}
