namespace _01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            const string Pattern = @"(\b[A-Z][a-z]+\b)\s(\b[A-Z][a-z]+\b)";
            var regex = new Regex(Pattern);
            string line = Console.ReadLine();
            while (line != "end")
            {
                if (regex.IsMatch(line))
                {
                    var matches = regex.Matches(line);
                    foreach (Match match in matches)
                    {
                        Console.WriteLine(match.Groups[1] + " " + match.Groups[2]);
                    }
                }
                
                line = Console.ReadLine();
            }
        }
    }
}
