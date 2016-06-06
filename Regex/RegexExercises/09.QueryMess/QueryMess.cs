namespace _09.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {

            string pattern = @"\?|&|=";
            string input = Console.ReadLine();

            while (input != "END")
            {
                List<string> str = Regex.Split(input, pattern).ToList();
                if (str.Count % 2 != 0)
                {
                    str.RemoveAt(0);
                }

                string patternRemoveSpaces = @"^(\+|%20)|(\+|%20)$";
                for (int i = 0; i < str.Count; i++)
                {
                    str[i] = Regex.Replace(str[i], patternRemoveSpaces, string.Empty);
                    str[i] = Regex.Replace(str[i], @"(\+|%20)", " ");
                    str[i] = Regex.Replace(str[i].Trim(), @"\s+", " ");
                }

                var dict = new Dictionary<string, List<string>>();
                
                for (int i = 0; i < str.Count - 1; i += 2)
                {
                    string key = str[i];
                    string value = str[i + 1];
                    if (!dict.ContainsKey(key))
                    {
                        dict.Add(key, new List<string>());
                        dict[key].Add(value);
                    }
                    else
                    {
                        dict[key].Add(value);
                    }
                }
                foreach (var item in dict)
                {
                    Console.Write(item.Key + "=[" + string.Join(", ", item.Value) + "]");
                }

                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
