namespace _03.SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(.)\1*";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match.Groups[1].Value);
            }

        }
    }
}
