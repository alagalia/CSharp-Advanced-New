using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Basic_Mark_up_Language
{
    using System.Text.RegularExpressions;

    class Basic_Mark_up_Language
    {
        static void Main()
        {
            List<string> result = new List<string>();

            string input = Console.ReadLine();
            while (input != @"<stop/>")
            {
                string command = Regex.Match(input, @"<\s*(\w+)").Groups[1].ToString();
                string content = Regex.Match(input, @"content\s*=\s*" + Regex.Escape("\"") + @"(.*)" + Regex.Escape("\"")).Groups[1].ToString();
                string wordForAdd;


                if (content != "")
                {
                    if (command == "inverse")
                    {
                        wordForAdd = new string(
                        content.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
                                          char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
                        result.Add(wordForAdd);
                    }
                    else if (command == "reverse")
                    {
                        wordForAdd = new string(content.Reverse().ToArray());
                        result.Add(wordForAdd);
                    }
                    else if (command == "repeat")
                    {
                        string times = Regex.Match(input, @"value\s*=\s*" + Regex.Escape("\"") + @"\s*(\d+)\s*" + Regex.Escape("\"")).Groups[1].ToString();
                        int n = int.Parse(times);
                        for (int i = 0; i < n; i++)
                        {
                            result.Add(content);
                        }
                    }
                }
                input = Console.ReadLine();
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + result[i]);
            }
        }
    }
}
