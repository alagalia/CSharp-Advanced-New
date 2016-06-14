namespace _10.PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main()
        {
            Func<string, string, string, bool> isLegal = (name, condition, args) =>
                {
                    bool result = false;
                    switch (condition)
                    {
                        case "StartsWith":
                            result = name.StartsWith(args);
                            break;
                        case "EndsWith":
                            result = name.EndsWith(args);
                            break;
                        case "Length":
                            result = name.Length == int.Parse(args);
                            break;
                    }
                    return result;
                };

            List<string> names = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commands = command.Split();
                string condition = commands[1];
                string args = commands[2];

                List<string> result = new List<string>();

                foreach (string name in names)
                {
                    if (commands[0] == "Double")
                    {
                        result.Add(name);
                        if (isLegal(name, condition, args))
                        {
                            result.Add(name);
                        }
                    }
                    else if (commands[0] == "Remove" && !isLegal(name, condition, args))
                    {
                        result.Add(name);
                    }
                }

                names = result;
                command = Console.ReadLine();
            }

            string finalVisitors = names.Count == 0
                                       ? "Nobody is going to the party!"
                                       : string.Join(", ", names) + " are going to the party!";
            Console.WriteLine(finalVisitors);
        }
    }
}
