namespace _11.PartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class PartyReservationFilterModule
    {
        public static void Main()
        {
            HashSet<string> filters = new HashSet<string>();
            string[] names = Console.ReadLine().Split();
            string line = Console.ReadLine();
            while (line != "Print")
            {
                string command = line.Substring(0, 3);

                string forAddOrDel = line.Split(';')[1] + ";" + line.Split(';')[2];
                if (command == "Add")
                {
                    filters.Add(forAddOrDel);
                }
                else if (command == "Rem")
                {
                    filters.Remove(forAddOrDel);
                }

                line = Console.ReadLine();
            }

            string[] finalNames = Tprf(filters, names);
            Console.WriteLine(string.Join(" ", finalNames));
        }

        private static Func<string, string, string, bool> isLegal = (name, filterType, parameter) =>
            {
                bool result = false;
                switch (filterType)
                {
                    case "Starts with":
                        result = name.StartsWith(parameter);
                        break;
                    case "Ends with":
                        result = name.EndsWith(parameter);
                        break;
                    case "Length":
                        result = name.Length == int.Parse(parameter);
                        break;
                    case "Contains":
                        result = name.Contains(parameter);
                        break;
                }

                return result;
            };

        private static string[] Tprf(HashSet<string> filters, string[] names)
        {
            foreach (string filter in filters)
            {
                string[] commands = filter.Split(';');
                string filterType = commands[0];
                string parameter = commands[1];

                string[] filterednames = names.Where(name => !isLegal(name, filterType, parameter)).ToArray();
                names = filterednames;
            }

            return names;
        }
    }
}
