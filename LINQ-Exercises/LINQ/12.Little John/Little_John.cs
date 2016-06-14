namespace _12.Little_John
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Little_John
    {
        public static void Main()
        {
            Dictionary<string, int> arrows = new Dictionary<string, int>()
                                                 {
                                                     { "Small", 0 },
                                                     { "Medium", 0 },
                                                     { "Large", 0 }
                                                 };

            for (int i = 0; i < 4; i++)
            {
                string pattern = @"(>{3}----->{2})|(>{2}----->{1})|(>{1}----->{1})";

                Regex reg = new Regex(pattern);

                string line = Console.ReadLine();
                MatchCollection matches = reg.Matches(line);

                foreach (Match match in matches)
                {
                    arrows["Large"] += match.Groups[1].Captures.Count;
                    arrows["Medium"] += match.Groups[2].Captures.Count;
                    arrows["Small"] += match.Groups[3].Captures.Count;
                }
            }

            string numDec = arrows.Aggregate(string.Empty, (current, item) => current + item.Value);
            string binary = Convert.ToString(int.Parse(numDec), 2);
            binary += Reverse(binary);
            string result = Convert.ToInt32(binary, 2).ToString();
            Console.WriteLine(result);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
