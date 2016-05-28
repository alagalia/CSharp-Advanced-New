namespace _14.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DragonArmy
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            // <type, <name, dragon>> 
            Dictionary<string, Dictionary<string, Dragon>> all = new Dictionary<string, Dictionary<string, Dragon>>();

            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split();
                string type = args[0];
                string name = args[1];
                int damage = args[2] == "null" ? 45 : int.Parse(args[2]);
                int health = args[3] == "null" ? 250 : int.Parse(args[3]);
                int armor = args[4] == "null" ? 10 : int.Parse(args[4]);
                Dragon currentDragon = new Dragon(type, name, damage, health, armor);

                if (!all.ContainsKey(type))
                {
                    all.Add(type, new Dictionary<string, Dragon>());
                    all[type].Add(name, null);
                }
                all[type][name] = currentDragon;
            }
            PrintResult(all);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, Dragon>> all)
        {
            foreach (var kvOuter in all)
            {
                var sortedByName = kvOuter.Value.OrderBy(x => x.Value.name);
                var numberOfDragons = sortedByName.Count();
                double totalDamage = kvOuter.Value.Select(v => v.Value.damage).Sum();
                double totalHealth = kvOuter.Value.Select(v => v.Value.health).Sum();
                double totalArmor = kvOuter.Value.Select(v => v.Value.armor).Sum();
                Console.WriteLine(kvOuter.Key + "::({0:0.00}/{1:0.00}/{2:0.00})", totalDamage / numberOfDragons, totalHealth / numberOfDragons, totalArmor / numberOfDragons);
                
                foreach (var kvInner in sortedByName)
                {
                    Console.WriteLine("-" + kvInner.Key + " -> damage: {0}, health: {1}, armor: {2} ", kvInner.Value.damage, kvInner.Value.health, kvInner.Value.armor);
                }
            }
        }
    }

    internal class Dragon
    {
        public string type;
        public string name;
        public int damage;
        public int health;
        public int armor;

        public Dragon(string type, string name, int damage, int health, int armor)
        {
            this.type = type;
            this.name = name;
            this.damage = damage;
            this.health = health;
            this.armor = armor;
        }
    }
}
